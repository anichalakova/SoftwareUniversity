function findPalindromes (str) {
	str = str.toLowerCase();
	str = str.replace(".", "");
	str = str.split(" ");

	var palindromes = [];

	for (var i = 0; i < str.length; i++) {
		var reversed = str[i].split('').reverse().join('');
		if (str[i] === reversed) {
			palindromes.push(str[i]);
		}
	}

	return palindromes;
}

console.log(findPalindromes('There is a man, his name was Bob.'));