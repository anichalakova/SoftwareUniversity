package Exams;

import java.util.Scanner;
 
public class NextDate
{
	public static void main(String[] args)
    {
    	Scanner input = new Scanner(System.in);
        int day = input.nextInt();
        int month = input.nextInt();
        int year = input.nextInt();
         
        day++;
 
        // september april june november
        if (month == 9 || month == 4 || month == 6 || month == 11)
        {
            if (day > 30)
            {
                day = 1;
                month++;                
            }
        }
        else if (month == 2)
        {
            if (year % 4 == 0)
            {
                if (day > 29)
                {
                    day = 1;
                    month++;
                }
            }
            else
            {
                if (day > 28)
                {
                    day = 1;
                    month++;
                }
            }
             
        }
        else
        {
            if (day > 31)
            {
                day = 1;
                month++;
 
                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
        }
        
        System.out.println(day + "." + month + "." + year);
    }
}