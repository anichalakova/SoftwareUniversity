import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.Locale;
import java.util.Scanner;

public class OrderOfProducts {

	public static void main(String[] args) throws Exception {
		Locale.setDefault(Locale.ROOT);
		ArrayList<Products> products = new ArrayList<Products>();
		try (Scanner input = new Scanner(new FileReader("Products.txt"))) {			
			while (input.hasNextLine()) {
				products.add(new Products(input.next(), input.nextDouble()));
			}				
		}
		double result = 0;
		try (Scanner input = new Scanner(new FileReader("Order.txt"))) {			
			while (input.hasNextLine()) {
				double quantity = input.nextDouble();
				String currentProduct = input.next();
				for (Products product : products) {
					if (product.getName().equals(currentProduct)) {
						result += quantity * product.getPrice();
					}
				}
			}				
		}
		try (BufferedWriter output = new BufferedWriter(new FileWriter("Output.txt"))) {
			output.write(String.format("%.2f", result));
		}
	}
}