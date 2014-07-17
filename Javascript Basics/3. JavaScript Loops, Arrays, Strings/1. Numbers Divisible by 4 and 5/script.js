function numbers (n) {
	for (var i = 1; i <= n; i++) {
		if (i % 4 == 0 || i % 5 == 0) {
			continue;
		}
		else {
			console.log(i);
		}
	}
}

console.log(numbers(20));
console.log(numbers(1));
console.log(13);