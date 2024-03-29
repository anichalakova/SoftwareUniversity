import java.awt.Color;
import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;


public class Player {
	private int y = Pong.WINDOW_HEIGHT / 2;
	private int yVelocity = 0;
	private Score score = new Score();
	//Size of the board
	private int width = 5;
	private int height = 40;
	private int magicAmount = 3;
	private List<Magic> magic = new ArrayList<Magic>();

	
	public Player() {
	}
	
	public List<Magic> getMagics(){
		return magic;
	}
	
	public int getMagicAmount(){
		return magicAmount;
	}	
	public void useMagic(){
		magicAmount-=1;
		magic.add(new Magic(5, y));
	}
	//Moving the player
	public void update() {
		y = y + yVelocity;
	}
	
	//Painting the player's board
	public void paint(Graphics g) {
		g.setColor(Color.YELLOW); //Color of the board
		g.fillRect(20, y, width, height); //Size of the board
	}
	
	//How fast the player moves
	public void setYVelocity(int speed) {
			if(y < 8){
				y = 8;
				yVelocity = 0;
			}
			else if (y > 250 - height){
				y = 250 - height;
				yVelocity = 0;
			} else {
				yVelocity = speed;
			}
	}
	
	public int getX() { //Position X
		return 20;
	}
	public int getY() { //Position Y
		return y;
	}
	public int getWidth() { //Board's width
		return width;
	}
	public int getHeight() { //Board's height
		return height;
	}
	public void decreaseHeight(){
		if(height >= 20){
			height-=5;
		}
	}
	public void increaseHeight(){
		if(height <= 100){
			height+=5;
		}
	}
	public void scores(){
		score.increase();
		increaseHeight();
	}
	public int getScore(){
		return score.get();
	}

	public void paintScore(int x, int y, Graphics g) {
		g.setColor(Color.WHITE);
		g.drawString("Player: " + this.getScore(),x,y);
	}
}
