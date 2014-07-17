function soothsayer (arr) {
	var years = arr[0];
	var lang = arr[1];
	var place = arr[2];
	var car = arr[3];

	var randomYear = years[Math.floor(Math.random()*years.length)];
	var randomLang = lang[Math.floor(Math.random()*lang.length)];
	var randomPlace = place[Math.floor(Math.random()*place.length)];
	var randomCar = car[Math.floor(Math.random()*car.length)];

	var str = "You will work " + randomYear + " years on " + randomLang + ". " 
				+ "You will live in " + randomPlace + " and drive a " + randomCar;

	return str;
}
console.log(soothsayer([["3", "5", "2", "7", "9"], 
					["Java", "Python", "C#", "JavaScript", "Ruby"], 
					["Silicon Valley", "London", "Las Vegas", "Paris", "Sofia"], 
					["BMW", "Audi", "Lada", "Skoda", "Opel"]]) )