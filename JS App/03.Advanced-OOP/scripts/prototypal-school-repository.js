var Person = {
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
};

var Student = Person.extend({
    init: function (firstName, lastName, age, grade) {
		'use strict';
        this._super = Object.create(this._super);
        this._super.init(firstName, lastName, age);
        this.grade = grade;
    },
    introduce: function () {
		'use strict';
		var intro = this._super.introduce() + ", grade: " + this.grade;
        return intro;
    }
});

var Teacher = Person.extend({
    init: function (firstName, lastName, age, speciality) {
		'use strict';
        this._super = Object.create(this._super);
        this._super.init(firstName, lastName, age);
        this.speciality = speciality;
    },
    introduce: function () {
		'use strict';
		var intro = this._super.introduce() + ", speciality: " + this.speciality;
        return intro;
    }
});

var School = {
    init: function (name, town, classes) {
		'use strict';
        this.name = name;
        this.town = town;
        this.classes = classes;
    },
    introduce: function () {
		'use strict';
        var i, data = "Name:" + this.name + ", Town:" + this.town + ", Classes:",
			length = this.classes.length;
        for (i = 0; i < length; i = i + 1) {
            data += this.classes[i].name + ", ";
        }
		var intro = data.substr(0, data.length - 2);
        return intro;
    }
};

var Course = {
    init: function (name, capacity, students, formTeacher) {
		'use strict';
        this.name = name;
        this.capacity = capacity;
        this.students = students;
        this.formTeacher = formTeacher;
    },
    introduce: function () {
		'use strict';
        var i, data = "Name:" + this.name + ", Capacity:" + this.capacity + ", Students:",
			length = this.students.length;
        for (i = 0; i < length; i = i + 1) {
            data += this.students[i].introduce() + ", ";
        }
        data += "Form-teacher" + this.formTeacher.introduce();
        return data;
    }
};

var pIvanov = Object.create(Student);
pIvanov.init("Petar", "Ivanov", 33, 4);

var kDonev = Object.create(Student);
kDonev.init("Kamen", "Donev", 26, 3);

var pIliev = Object.create(Student);
pIliev.init("Pavel", "Iliev", 29, 2);

var aPopov = Object.create(Student);
aPopov.init("Alexandar", "Popov", 22, 1);

console.log(pIvanov.introduce());
console.log(kDonev.introduce());
console.log(pIliev.introduce());
console.log(aPopov.introduce());

var pKolev = Object.create(Teacher);
pKolev.init("Pavel", "Kolev", 24, "Web Technologies");

var gGeorgiev = Object.create(Teacher);
gGeorgiev.init("Georgi", "Georgiev", 23, "All with code");

console.log(pKolev.introduce());
console.log(gGeorgiev.introduce());

var webTech = Object.create(Course);
webTech.init("webTech", 22, new Array(pIvanov, kDonev, pIliev, aPopov), pKolev);

var proUI = Object.create(Course);
proUI.init("proUI", 11, new Array(pIvanov, pIliev, aPopov), gGeorgiev);

console.log(webTech.introduce());
console.log(proUI.introduce());

var academy = Object.create(School);
academy.init("Telerik Academy", "Sofia", new Array(webTech, proUI));
console.log(academy.introduce());