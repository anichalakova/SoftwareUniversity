import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.Collections;

public class ListOfProducts {

	public static void main(String[] args) {
		ArrayList<Products> products = new ArrayList<Products> ();
		BufferedReader reader;
        BufferedWriter writer = null;
        
		try {
			reader = new BufferedReader(new FileReader("ProductsInput.txt"));
			String line = null;
			while ((line = reader.readLine()) != null) {
				String[] input = line.split(" ");
				products.add(new Products(input[0], Double.parseDouble(input[1])));
			}
			Collections.sort(products);
			
			writer = new BufferedWriter(new FileWriter("ProductsOutput.txt"));
            for(Products product : products){
                    writer.write(product.getName() + " " + product.getPrice() + "\r\n");
            }
            writer.close();
            
		} catch (Exception e) {
			System.out.println("Missing File");
		}
	}

}
