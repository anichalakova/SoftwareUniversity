function reverseAll(str) {
	arr = str.split(" ");
	for (var i = 0; i < arr.length; i++) {
		arr[i] = arr[i].split("").reverse().join("");
	}
	return arr;
}

console.log(reverseAll('Hello, how are you.'));