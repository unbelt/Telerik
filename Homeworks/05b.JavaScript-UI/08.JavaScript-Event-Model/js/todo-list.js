function addTask() {
    'use strict';

    var list = document.getElementById('todo-list'),
        todo = document.getElementById('task').value,
        task = list.childNodes.length,
        li = document.createElement('li'),
        check = document.createElement('input'),
        remove = document.createElement('input');

    if (todo) {
        check.setAttribute('type', 'checkbox');
        check.setAttribute('id', task);
        check.setAttribute('onclick', 'checkTask(' + task + ')');

        remove.setAttribute('type', 'button');
        remove.setAttribute('value', 'x');
        remove.setAttribute('onclick', 'removeTask(' + task + ')');

        li.appendChild(remove);
        li.innerHTML += todo;
        li.appendChild(check);
        list.appendChild(li);
    } else {
        alert('You must enter TODO task!');
    }
}

function checkTask(complete) {
    'use strict';

    var task = document.getElementById('todo-list').childNodes[complete];

    document.getElementById(complete).checked ?
        task.style.textDecoration = 'line-through' : task.style.textDecoration = 'none';
}

function removeTask(id) {
    'use strict';

    document.getElementById('todo-list').childNodes[id].remove();
}

function clearList() {
    'use strict';

    document.getElementById('todo-list').innerHTML = '';
}
