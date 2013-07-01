var Person = Class.create({
	init: function (firstName, lastName, age) {
		'use strict';
		this.firstName = firstName;
		this.lastName = lastName;
		this.age = age;
	},
	introduce: function () {
		'use strict';
		var intro = "Name:" + this.firstName + " " + this.lastName + ", Age: " + this.age;
		return intro;
	}
});

var Student = Class.create({
	init: function (firstName, lastName, age, grade) {
		'use strict';
		this._super = new this._super(arguments);
		this._super.init(firstName, lastName, age);
		this.grade = grade;
	},
	introduce: function () {
		'use strict';
		var intro = this._super.introduce() + ", grade: " + this.grade;
		return intro;
	}
});

Student.inherit(Person);

var Teacher = Class.create({
	init: function (firstName, lastName, age, speciality) {
		'use strict';
		this._super = new this._super(arguments);
		this._super.init(firstName, lastName, age);
		this.speciality = speciality;
	},
	introduce: function () {
		'use strict';
		var intro = this._super.introduce() + ", speciality: " + this.speciality;
		return intro;
	}
});

Teacher.inherit(Person);

var School = Class.create({
	init: function (name, town, classes) {
		'use strict';
		this.name = name;
		this.town = town;
		this.classes = classes;
	},
	introduce: function () {
		'use strict';
		var data = "Name:" + this.name + ", Town:" + this.town + ", Classes:",
			i,
			intro,
			length = this.classes.length;
		for (i = 0; i < length; i = i + 1) {
			data += this.classes[i].name + ", ";
		}
		intro = data.substr(0, data.length - 2);
		return intro;
	}
});

var Course = Class.create({
	init: function (name, capacity, students, formTeacher) {
		'use strict';
		this.name = name;
		this.capacity = capacity;
		this.students = students;
		this.formTeacher = formTeacher;
	},
	introduce: function () {
		'use strict';
		var data = "Name:" + this.name + ", Capacity:" + this.capacity + ", Students:",
			i,
			length = this.students.length;
		for (i = 0; i < length; i = i + 1) {
			data += this.students[i].introduce() + ", ";
		}
		data += "Form-teacher" + this.formTeacher.introduce();
		return data;
	}
});

var pIvanov = new Student("Petar", "Ivanov", 33, 4);
var kDonev = new Student("Kamen", "Donev", 26, 3);
var pIliev = new Student("Pavel", "Iliev", 29, 2);
var aPopov = new Student("Alexandar", "Popov", 22, 1);

console.log(pIvanov.introduce());
console.log(kDonev.introduce());
console.log(pIliev.introduce());
console.log(aPopov.introduce());

var pKolev = new Teacher("Pavel", "Kolev", 24, "Web Technologies");
var gGeorgiev = new Teacher("Georgi", "Georgiev", 23, "All with code");

console.log(pKolev.introduce());
console.log(gGeorgiev.introduce());

var webTech = new Course("webTech", 22, new Array(pIvanov, kDonev, pIliev, aPopov), pKolev);
var proUI = new Course("proUI", 11, new Array(pIvanov, pIliev, aPopov), gGeorgiev);

console.log(webTech.introduce());
console.log(proUI.introduce());

var academy = new School("Telerik Academy", "Sofia", new Array(webTech, proUI));

console.log(academy.introduce());