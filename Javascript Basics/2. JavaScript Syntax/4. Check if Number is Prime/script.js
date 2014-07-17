function primeChecker () {
	var x = prompt("Enter number");
	var counter = 0;
	for (var i = 1; i < x; i++) {
		if (x % i == 0) {
			counter++;
		}
	}

	if (counter > 1) {
		console.log("Not prime");
	}
	else {
		console.log("Prime");
	}
}

primeChecker();