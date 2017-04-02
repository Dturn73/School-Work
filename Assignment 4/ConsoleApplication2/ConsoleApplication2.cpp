/*
David Turner
4/2/2017
Assignment 4
This program repeatedly ask the user for a number, then once the user enters 0,
the code displays the min, max and average of all values entered.
*/

#include "stdafx.h"
#include <stdio.h>

int _tmain(int argc, _TCHAR* argv[]){
	//declare variables.
	float max_in	= 0.0;
	float min_in	= 0.0;
	float input		= 0.0;
	float total		= 0.0;
	float average	= 0.0;
	int x;
	int num_count	= 0;
	
	
		
	do{
		//get input from the user.
		printf("Please enter a value or '0' to exit:\n");
		scanf_s("%f", &input);
		//if the min_in is > input, then assign min_in to the input.
		if (input < min_in){
			min_in = input;
		}
		//assign max_in to the input only if max_in is < input.
		if(max_in < input){
			max_in = input;
		}
		//increment counter var to keep track of entries.
		num_count ++;
		//accumalate total.
		total = total + input;
		//while the input is not equal to zero.
	}while (input != 0.0);
	//calculate the average
	average = (total/(num_count -1));
	//Once the loop is over, display the calculated values (min, max and the average) with a proper wording in three lines.
	printf("The minimum entry was:%19.2f\n", min_in);
	printf("The maximum entry was:%19.2f\n", max_in);
	printf("The average of all entries was:%10.2f\n", average);

	scanf_s("%d",&x);
	return 0;
}

