import java.io.BufferedReader;
import java.io.FileReader;

public class SumNumbersFromATextFile {

	public static void main(String[] args) {
		try {
			BufferedReader reader = new BufferedReader(new FileReader("input.txt"));
			String line = null;
			int sum = 0;
			while ((line = reader.readLine()) != null) {
				sum += Integer.parseInt(line);
			}
			System.out.println(sum);
		}
		catch (Exception e) {
				System.out.println("Missing File");
		}
	}

}
