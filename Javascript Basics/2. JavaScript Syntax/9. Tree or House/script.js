function treeOrHouse (arr) {
	var a = arr[0];
	var b = arr[1];

	var houseArea = a * a + (a * (a * 2 / 3)) / 2;
    var treeArea = b * (b / 3) + Math.PI * (b * 2 / 3) * (b * 2 / 3);
    
    if (houseArea > treeArea) {
    	console.log("house");
    }
    else if(treeArea > houseArea) {
    	console.log("tree");
    }
    else {
    	console.log('equal');
    }
}

console.log([3, 2]);