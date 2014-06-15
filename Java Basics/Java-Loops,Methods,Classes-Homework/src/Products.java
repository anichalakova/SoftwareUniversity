
public class Products implements Comparable<Products>{
	private String name;
	private double price;
	
	public Products(String string, double parseDouble) {
		// TODO Auto-generated constructor stub
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public double getPrice() {
		return price;
	}
	public void setPrice(double price) {
		this.price = price;
	}
	public int compareTo(Products compareFruit) {
        
        double otherPrice = ((Products) compareFruit).getPrice();

        //ascending order
        if(this.price>otherPrice) return 1;
        else
        if(this.price==otherPrice) return 0;
        return -1;
}  
	
}
