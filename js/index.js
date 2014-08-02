(function() {

  schedule = [
    ['Lesson 1 - GitHub and Unity',	20, new Date('2014-09-25T23:59:59'), '<a href="Setup.html">GitHub and Unity</a>'],
    ['Lesson 2 - Developing in Unity', 	20, new Date('2014-09-30T23:59:59'), '<a href="Unity-1.html">Developing in Unity</a>'],
    ['Lesson 3 - Tutorials in Unity', 20, new Date('2014-10-14T23:59:59'), '<a href="Tutorials.html">Tutorials In Unity</a>'],
    ['Lesson 4 - The Game Design Document', 20, new Date('2014-10-16T23:59:59'), '<a href="GDD.html">The Game Design Document</a>'],
    ['Lesson 5 - Your Game Pitch', 20, new Date('2014-10-21T23:59:59'), '<a href="Pitch.html">Your Game Pitch</a>'],
    ['Lesson 6 - Game Design Project', 20, new Date('2014-11-25T23:59:59'), '<a href="Project.html">Game Design Project</a>']
  ];

  app.onload = function() {
    app.buildTable();
  };

  app.buildTable = function() {
    var tbody = document.getElementsByTagName('tbody')[0];
    for (var i = 0; i < schedule.length; ++i) {
      var tr = document.createElement('tr');
      var td = document.createElement('td'); // activity column
      td.innerHTML = schedule[i][3];
      td.className = 'activity';
      tr.appendChild(td);
      td = document.createElement('td'); // deadline column
      td.innerHTML = app.extractDate(schedule[i][2]);
      td.className = 'deadline';
      tr.appendChild(td);
      td = document.createElement('td'); // points column
      td.innerHTML = schedule[i][1];
      td.className = 'points';
      tr.appendChild(td);
      tbody.appendChild(tr);
    }
  };

})();

