#pragma once
#include "Combi.h"

int   knapsack_s(
    int V,         // [in]  ����������� ������� 
    short n,       // [in]  ���������� ����� ��������� 
    const int v[], // [in]  ������ �������� ������� ����  
    const int c[], // [in]  ��������� �������� ������� ����     
    short m[]      // [out] ���������� ��������� 
);
int calcv(combi::subset s, const int v[]);
int calcc(combi::subset s, const int v[], const int c[]);
void setm(combi::subset s, short m[]);
