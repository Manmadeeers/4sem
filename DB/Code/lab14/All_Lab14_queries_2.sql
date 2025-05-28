use FIL_MyBase

CREATE FUNCTION dbo.COUNT_ORDERS(
    @id_заказчика INT = NULL,
    @id_товара INT = NULL
)
RETURNS INT
AS
BEGIN
    DECLARE @amount INT = (
        SELECT COUNT(*) 
        FROM Заказы
        WHERE id_заказчика = ISNULL(@id_заказчика, id_заказчика)
          AND id_товара = ISNULL(@id_товара, id_товара)
    );
    RETURN @amount;
END
GO

-- Пример использования:
SELECT dbo.COUNT_ORDERS(1, NULL) AS [Заказы клиента 1];
SELECT dbo.COUNT_ORDERS(NULL, 5) AS [Заказы товара 5];

CREATE FUNCTION dbo.GET_CUSTOMER_ORDERS(@id_заказчика INT)
RETURNS VARCHAR(MAX)
AS
BEGIN
    DECLARE @orders VARCHAR(MAX) = 'Заказы: ';
    DECLARE @order_info VARCHAR(200);
    
    DECLARE order_cursor CURSOR LOCAL FOR
    SELECT 'Заказ №' + CAST(id AS VARCHAR) + ' (' + тип_доставки + ')'
    FROM Заказы 
    WHERE id_заказчика = @id_заказчика;
    
    OPEN order_cursor;
    FETCH NEXT FROM order_cursor INTO @order_info;
    
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @orders += @order_info + ', ';
        FETCH NEXT FROM order_cursor INTO @order_info;
    END
    
    CLOSE order_cursor;
    DEALLOCATE order_cursor;
    
    RETURN @orders;
END
GO

-- Пример использования:
SELECT dbo.GET_CUSTOMER_ORDERS(1) AS [Список заказов];

CREATE FUNCTION dbo.FILTER_CUSTOMERS(
    @улица VARCHAR(100) = NULL,
    @минимальные_заказы INT = 0
)
RETURNS TABLE
AS
RETURN (
    SELECT з.*, COUNT(за.id) AS КоличествоЗаказов
    FROM Заказчики з
    LEFT JOIN Заказы за ON з.id = за.id_заказчика
    WHERE з.улица = ISNULL(@улица, з.улица)
    GROUP BY з.id, з.название_фирмы, з.улица, з.дом, з.телефон, з.контактное_лицо
    HAVING COUNT(за.id) >= @минимальные_заказы
)
GO

-- Пример использования:
SELECT * FROM dbo.FILTER_CUSTOMERS('Ленина', 3);

CREATE FUNCTION dbo.AVG_ORDER_VALUE(@id_заказчика INT = NULL)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN (
        SELECT AVG(т.цена * за.количество)
        FROM Заказы за
        JOIN Товары т ON за.id_товара = т.id
        WHERE за.id_заказчика = ISNULL(@id_заказчика, за.id_заказчика)
    );
END
GO

-- Пример использования:
SELECT dbo.AVG_ORDER_VALUE(1) AS [Средний чек];

CREATE FUNCTION dbo.PRODUCT_REPORT(@min_quantity INT)
RETURNS @report TABLE (
    Товар VARCHAR(255),
    КоличествоЗаказов INT,
    ОбщееКоличество INT,
    ОбщаяСтоимость DECIMAL(12,2)
)
AS
BEGIN
    INSERT INTO @report
    SELECT 
        т.название_товара,
        COUNT(за.id),
        SUM(за.количество),
        SUM(т.цена * за.количество)
    FROM Товары т
    LEFT JOIN Заказы за ON т.id = за.id_товара
    GROUP BY т.id, т.название_товара
    HAVING SUM(за.количество) >= @min_quantity
    
    RETURN
END
GO

-- Пример использования:
SELECT * FROM dbo.PRODUCT_REPORT(10);


s