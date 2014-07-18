function bracketChecker (str) {
	str = str.replace(/\s/g, '');

	var openCount = 0;
	var closeCount = 0;
	
	for (var i = 0; i < str.length; i++) {
		if (str[i] === '(') {
			openCount++;
		}
		else if (str[i] === ')') {
			closeCount++;
		}
	}

	if (openCount === closeCount) {
		return "correct"
	}
	else if (openCount > closeCount || closeCount > openCount) {
		return "incorrect";
	}
}

console.log(bracketChecker('( ( a + b ) / 5 – d )'));