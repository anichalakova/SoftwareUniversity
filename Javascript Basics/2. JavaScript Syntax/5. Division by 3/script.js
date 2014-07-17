function division (num) {
	var x = num % 10;
	num = parseInt(num / 10);
	var y = num % 10;
	num = parseInt(num / 10);
	var z = num % 10;
	num = parseInt(num / 10);
	
	var sum = x + y + z;
	if (sum % 3 == 0) {
		console.log('divides by 3 without remainder');
	}
	else {
		console.log('divides by 3 with remainder');
	}	
}

console.log(division(12));