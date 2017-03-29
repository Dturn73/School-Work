// Practice  using loops example 2.cpp : This little program asks the user to ent a positive number,
// then it shows the factorial.

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[]){
	int n = 0;
	int factorial = 0;
	int x = 0;

	//get input into n
	printf("Please enter a positive number..\n");
	scanf_s("%d", &n);
		//multiply n by factorial n
		factorial = n * n;

	do{
		//subtact one from n
		n = n - 1;
		//if n is 1 end loop
	} while (n != 1);
	//show factorial n
	printf("%d\n", factorial);
	scanf_s("%d", &x);
	return 0;
}

