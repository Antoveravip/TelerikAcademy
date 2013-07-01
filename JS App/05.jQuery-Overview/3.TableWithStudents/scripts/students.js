(function ($) {
	var Student = Class.create({
		init: function (firstName, lastName, grade) {
			this.firstName = firstName;
			this.lastName = lastName;
			this.grade = grade;
		}
	});

	var students = [];
	
	students.push(new Student("Petar", "Ivanov", 4));
	students.push(new Student("Kamen", "Donev", 3));
	students.push(new Student("Pavel", "Iliev", 2));
	students.push(new Student("Alexandar", "Popov", 1));
	students.push(new Student("Ivan", "Angelov", 4));
	students.push(new Student("Ana", "Spasova", 3));
	students.push(new Student("Yana", "Georgieva", 3));

	var table = $("<table></table>");
	table.append("<thead>" +
					"<tr>" +
						"<th>First name</th>" +
						"<th>Last name</th>" +
						"<th>Grade</th>" +
					"</tr>" +
				 "</thead>");

	var tbody = $("<tbody></tbody>");
	for (var i = 0, studentsCount = students.length; i < studentsCount; i++) {
		tbody.append("<tr>" +
						"<td>" + students[i].firstName + "</td>" +
						"<td>" + students[i].lastName + "</td>" +
						"<td>" + students[i].grade + "</td>" +
					 "<tr>");
	}
	
	table.append(tbody);
	table.appendTo($("#wrapper"));	
})(jQuery);