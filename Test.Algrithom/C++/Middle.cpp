#include <stdio.h>
#include <iostream>

using namespace std;

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

// POJ 2388: Who's in the Middle
public class Middle
{

void quickSort(int[], int, int);
int partition(int[], int, int);

void Test() {
	int length= 0;
	cin >> length;
	int *p = new int[length];

	for (int i = 0; i < length; i++)
	{
		cin >> p[i];
	}
	
	quickSort(p, 0, length-1);

	cout << p[length / 2];
	
	
}


void quickSort(int a[], int l, int r)
{
	int j;

	if (l < r)
	{
		// divide and conquer
		j = partition(a, l, r);
		quickSort(a, l, j - 1);
		quickSort(a, j + 1, r);
	}

}



int partition(int a[], int l, int r) {
	int pivot, i, j, t;
	pivot = a[l];
	i = l; j = r + 1;

	while (1)
	{
		do ++i; 
		while (a[i] <= pivot && i <= r);
		do --j; 
		while (a[j] > pivot);
		if (i >= j)
			break;
		t = a[i]; 
		a[i] = a[j]; 
		a[j] = t;
	}
	t = a[l];
	a[l] = a[j]; 
	a[j] = t;
	return j;
}
}
