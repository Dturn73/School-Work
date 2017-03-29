// This is Example 1 from my C class. It's an execise on how to use indeterminate loops in C.
//

#include "stdafx.h"
#include <stdio.h>


int _tmain(int argc, _TCHAR* argv[]){
	//declare variables
	int total = 0;
	int count = 0;
	int entry = 0;
	int x;

	do{
		//get entry
		printf("Please enter a number\n");
		scanf_s("%d",&entry);
		//count number of entries
		count ++;
		//add entry to running total
		total = total + entry;
		//loop while entry is not equal to 0
	} while (entry != 0);
	//after the loop show total/count
	printf("The total is:%d\n", total);
	printf("The count is:%d\n", count -1);
	scanf_s("%d", &x);
	return 0;
}

