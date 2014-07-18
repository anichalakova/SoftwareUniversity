function cardFrequencies (str) {
	str = str.replace(/♣/g, "");
	str = str.replace(/♥/g, "");
	str = str.replace(/♦/g, "");
	str = str.replace(/♠/g, "");

	str = str.split(" ");

	var map = {};
	var total = 0;
	for (var i = 0; i < str.length; i++) {
		var count = 0;
		var key = str[i]
		for (var j = 0; j < str.length; j++) {
			if (str[i] === str[j]) {
				count++;
			}
		}
		map[str[i]] = count;
	}

	for (var key in map) {
		total += map[key];
	}
	for (var key in map) {
		console.log(key + " " + (map[key] / total) * 100 + "%");
	}
}

console.log(cardFrequencies('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦'));