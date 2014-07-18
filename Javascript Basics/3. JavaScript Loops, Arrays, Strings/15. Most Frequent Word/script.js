function mostFrequent(str) {
	var map = {};
	str = str.split(" ");

	for (var i = 0; i < str.length; i++) {
		var count = 0;
		var  name = str[i];
		for (var j = 0; j < str.length; j++) {
			if (str[i] === str[j]) {
				count++;
			}
		}
		map[str[i]] = count;
	}

	var frequent = 0;
	var frElement;
	for(var key in map){
  		if (map[key] > frequent) {
  			frequent = map[key];
  			frElement = key;
  		}
	}

	return frElement + " " + frequent;
	
}

console.log(mostFrequent('in the middle of the night'));
console.log(mostFrequent('Welcome to SoftUni. Welcome to Java. Welcome everyone.'));