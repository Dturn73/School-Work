/*	David Turner
*	Assignment 7
*	CS50
*	4/30/2017
*	This is a simple banking menu program. It asks the user to choose from a small list of choices
*	and it uses a switch statement to determine which function to perform based on the user's choice.
*/

#include <stdio.h>
#include <stdlib.h>

//function prototypes
float balance(float);
float deposit(float,float);
float withdrawal(float,float);
void quit(char);

int main(){
	int	counter = 10;
	float currentBalance = 0;
	float depositAmount = 0;
	float withdrawalAmount = 0;
	char f = '\0';

	do{
		int menu = 0;
		printf("Please choose a menu option: 1-get balance, 2-make deposit, 3-make withdrawal, or 4-to quit\n\n\n");
		scanf_s("%d", &menu);
		switch(menu){
			case 1 :
				printf("Balance is: $%5.2f\n\n\n",balance(currentBalance));
				break;
			case 2 :
				printf("Please enter deposit amount\n");
				scanf_s("%f", &depositAmount);
				currentBalance = deposit(depositAmount, currentBalance);
				printf("Balance is: $%5.2f\n\n\n",currentBalance);
				break;
			case 3 :
				printf("Please enter withdrawal amount\n");
				scanf_s("%f", &withdrawalAmount);
				currentBalance = withdrawal(withdrawalAmount, currentBalance);
				printf("Balancs is: $%5.2f\n\n\n",currentBalance);
				break;
			case 4 :
				scanf_s("%c", &f);
				quit(f);
				break;
			default :
				printf("Must choose options 1, 2, 3, or 4. Please try again.\n\n\n");
				break;
		}
		counter --;
		currentBalance = currentBalance;
	}while(counter != 0);
	return 0;
}

//This function returns the current balance to the user.
float balance(float currentBalance){
	return currentBalance;

}

//This function returns the current balance plus the deposit amount. Otherwise, it doesn't alter the current balance.
float deposit(float depositAmount, float currentBalance){
	if(depositAmount < 10000 && depositAmount > 0){
		currentBalance = currentBalance + depositAmount;
		return currentBalance;
	}
	else{
		printf("Deposit amount cannot be more than $10,000 or a negative number.\n");
		return currentBalance;
	}
}

//This function returns the current balance less the widtdrawal amount. Otherwise, it doesn't alter the current balance.
float withdrawal(float withdrawalAmount, float currentBalance){
	if(withdrawalAmount > 0 && (currentBalance - withdrawalAmount >= 10)){
		currentBalance = currentBalance - withdrawalAmount;
		return currentBalance;
	}
	else{
		printf("Withdrawal entry cannot be negative or leave less than $10 in the account.\n");
		return currentBalance;
	}
}

//This function closes the program after the user presses the Enter key
void quit(char c){     
	printf("Press Enter to continue:\n");
	scanf_s("%c",&c);
	exit(0);
}