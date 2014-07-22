function findYoungest (arr) {
	var smallest = arr[0];

	for (var i = 0; i < arr.length; i++) {
		if (arr[i].age < smallest.age) {
			smallest = arr[i];
		}
	}

	return ("The youngest person is " + smallest.firstname + " " + smallest.lastname);
}

console.log(findYoungest([
  { firstname : 'George', lastname: 'Kolev', age: 32}, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},
  { firstname : 'Baba', lastname: 'Ginka', age: 40}
 ]));