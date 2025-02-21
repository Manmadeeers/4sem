using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Extensions.Logging;
internal class Program//�����, � ������� ��������� ����������� ����� Main
{
    private static void Main(string[] args)//��� ����� - ����� ����� � ���������
    {
        var builder = WebApplication.CreateBuilder(args);//�������� ����� ���������� WebApplication ������� � ������ web ���������� � ����������� 
        //�����: ���������������� � ��, ����������� ����������� ���

        builder.Services.AddHttpLogging(o =>//����� � ������
        {
            o.LoggingFields = HttpLoggingFields.RequestMethod | //����� �������
                                HttpLoggingFields.RequestPath | //���� �������
                                HttpLoggingFields.ResponseStatusCode;//��� ������


        });

        builder.Logging.AddFilter("Microsoft.AspNetCore.HttpLogging", LogLevel.Information);//��������� ������
        var app = builder.Build();//������ ��������� WebApplication �� ������ �������� �� buildera
       
        app.UseHttpLogging();//����� � ������

        app.MapGet("/", () => "My first ASPA!");//���������� ������� ��� GET ��������.
        // MaoGet ����� endpoint, �� �������� ����� �������������� GET �������
        //

        app.Run();//��������� � �������� ������� �� ������� HTTP ��������
    }
}