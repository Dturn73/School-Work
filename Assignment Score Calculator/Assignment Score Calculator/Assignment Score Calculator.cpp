/* 
Name: David Turner Date: 3/19/2017 Assignment: #2 -This 
assignment is an application that asks the end user to enter
their scores and the code calculates the weighted total score.
*/

#include "stdafx.h"
#include <stdio.h>

int _tmain(int argc, _TCHAR* argv[]){
	//decaring variables
	int assignment_one = 0;
	int assignment_two= 0;
	int assignment_three = 0;
	int mid_term_score = 0;
	int final_exam_score = 0;
	int total = 0;
	int x;
	double total_weighted_score = 0;
	double assignment_avg = 0;
	
	
	//declare constants
	const double  ASSIGNMENT_WEIGHT= 0.40;
	const double  MIDTERM_WEIGHT = 0.30;
	const double FINAL_WEIGHT = 0.30;

	//explaing to the user what's going on
	printf("This program calculates your weighted score.\n");
	printf("Just enter you scores below.\n\n\n");
	
	//get values from user
	printf("Enter assignment one score\n");
	scanf_s("%d",&assignment_one);

	printf("Enter assignment two score\n");
	scanf_s("%d",&assignment_two);

	printf("Enter assignment three score\n");
	scanf_s("%d",&assignment_three);

	printf("Enter midterm score\n");
	scanf_s("%d",&mid_term_score);

	printf("Enter final exam score\n");
	scanf_s("%d",&final_exam_score);

	//calculate total, assignment avg, and total weighted score
	total = assignment_one + assignment_two + assignment_three;
	assignment_avg = total / 3;
	total_weighted_score = ((assignment_avg*ASSIGNMENT_WEIGHT) + (mid_term_score*MIDTERM_WEIGHT) + (final_exam_score*FINAL_WEIGHT));

	//print results
	printf("Your final score is: %lf\n\n", total_weighted_score);
	printf("Please press any number followed by 'enter' to close window.");
	scanf_s("%d",&x);
	return 0;
}
