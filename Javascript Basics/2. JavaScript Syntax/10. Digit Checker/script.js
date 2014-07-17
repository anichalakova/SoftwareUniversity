function checker (numStr) {
	var num = parseInt(numStr[0]);
	num = parseInt(num / 10);
	num = parseInt(num / 10);
	var x = num % 10;

	if (x == 3) {
		return true;
	}
	else {
		return false;
	}
}

console.log(checker(['1235']));
console.log(checker(['25368']));
console.log(checker(['123456']));