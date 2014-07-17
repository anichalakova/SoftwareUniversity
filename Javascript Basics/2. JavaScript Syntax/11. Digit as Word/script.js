function digitAsWord (num) {
	var number = num[0];
	switch(number) {
		case('1'): return "One";
		case('2'): return "Two";
		case('3'): return "Three";
		case('4'): return "Four";
		case('5'): return "Five";
		case('6'): return "Six";
		case('7'): return "Seven";
		case('8'): return "Eight";
		case('9'): return "Nine";
		case('0'): return "Zero";
	}
}

console.log(digitAsWord(['8']));
console.log(digitAsWord(['3']));
console.log(digitAsWord(['5']));