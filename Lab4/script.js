let numbers = [];
let strings = [];

function addNumber() {
    let num = document.getElementById('numInput').value;
    if(num) {
        numbers.push(parseInt(num));
        document.getElementById('arrayOutput').innerText = `Tabloul: [${numbers.join(', ')}]`;
        document.getElementById('numInput').value = '';
    }
}

function sortNumbers() {
    numbers.sort((a, b) => a - b);
    document.getElementById('arrayOutput').innerText = `Tabloul: [${numbers.join(', ')}]`;
}

function addString() {
  let str = document.getElementById('strInput').value;
  if(str) {
      strings.push(str);
      document.getElementById('stringOutput').innerText = `Șiruri: [${strings.join(', ')}]`;
      document.getElementById('strInput').value = '';
  }
}

function sortStrings() {
  strings.sort((a, b) => a.localeCompare(b, undefined, { sensitivity: 'base' }));
  document.getElementById('stringOutput').innerText = `Șiruri: [${strings.join(', ')}]`;
}

document.getElementById('hoverButton').addEventListener('mouseover', function() {
    this.style.backgroundColor = 'red';
});

document.getElementById('hoverButton').addEventListener('mouseout', function() {
    this.style.backgroundColor = '';
});

document.addEventListener('keydown', function(event) {
    document.getElementById('keyEvent').innerText = `Ai apăsat: ${event.key}`;
});

window.addEventListener('resize', function() {
    document.getElementById('windowSize').innerText = `Dimensiuni: ${window.innerWidth} x ${window.innerHeight}`;
});

function generateBox() {
    let box = document.createElement('div');
    box.style.width = '50px';
    box.style.height = '50px';
    box.style.backgroundColor = 'blue';
    box.style.margin = '5px';
    boxContainer.appendChild(box);
}
