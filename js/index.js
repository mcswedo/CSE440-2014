(function() {

  schedule = [
    ['Lesson 1 - Introductions to GitHub and Unity', 10, new Date('2014-09-30T23:59:59'), '<a href="Introduction.html">Week 1: Introductions to GitHub and Unity</a>'],
    ['Lesson 2 - Tutorials in Unity', 10, new Date('2014-10-16T23:59:59'), '<a href="Tutorials.html">Weeks 2 & 3: Tutorials in Unity</a>'],
    ['Lesson 3 - Hello World - Input & Movement, Textures & Assets', 20, new Date('2014-10-23T23:59:59'), '<a href="HelloWorld.html">Week 4: Hello World - Input & Movement, Textures & Assets</a>'],
    ['Lesson 4 - Creating a Game World', 20, new Date('2014-10-30T23:59:59'), '<a href="GameWorld.html">Week 5: Creating a Game World</a>'],
    ['Lesson 5 - Physics, Collisions, and Triggers', 20, new Date('2014-11-07T23:59:59'), '<a href="Physics.html">Week 6: Physics, Collisions, and Triggers</a>'],
    ['Lesson 6 - Audio & GUI', 20, new Date('2014-11-13T23:59:59'), '<a href="Audio-GUI.html">Week 7: Audio & GUI</a>']
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

