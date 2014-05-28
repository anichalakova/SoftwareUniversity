import java.util.Scanner;
import org.joda.time.DateTime;
import org.joda.time.Days;


public class DaysBetweenTwoDates {

	public static void main(String[] args) {
		DateTime test = new DateTime();
		Scanner input = new Scanner(System.in);
		
		String firstDate = input.next();
		String secondDate = input.next();
		
		String[] firstDateArray = firstDate.split("-");
		String[] secondDateArray = firstDate.split("-");
		
		DateTime past = new DateTime(Integer.parseInt(firstDateArray[2]),
                						Integer.parseInt(firstDateArray[1]),
                						Integer.parseInt(firstDateArray[0]), 0,0);
		DateTime today = new DateTime(Integer.parseInt(secondDateArray[2]),
                						Integer.parseInt(secondDateArray[1]),
                						Integer.parseInt(secondDateArray[0]), 0,0);
		int days = Days.daysBetween(past, today).getDays();
		System.out.println(days);
	}
}
