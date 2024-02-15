const cells = document.querySelectorAll('.cell');
const resetButton = document.querySelector('#reset');
const board = document.querySelector('.board');

let currentPlayer = 'x';
let gameOver = false;

function hasClass(el, className) {
  return el.classList.contains(className);
};

function handleCellClick(event) {
  const cell = event.target;

  if (gameOver)
    return;

    // E' clickabile solo una cella non ancora "giocata"
  if (cell.classList.contains('player-x') ||
      cell.classList.contains('player-o'))
  {
    return;
  }

  var currentPlayerClass = 'player-'+currentPlayer;
  cell.classList.add(currentPlayerClass);
  cell.textContent = currentPlayer;
  checkWin();
  currentPlayer = currentPlayer === 'x' ? 'o' : 'x';
};

function checkWin() {
  const winningCombinations = [
    [1, 2, 3],  // riga 1
    [4, 5, 6],  // riga 2
    [7, 8, 9],  // riga 3
    [1, 4, 7],  // colonna 1
    [2, 5, 8],  // colonna 2
    [3, 6, 9],  // colonna 3
    [1, 5, 9],  // diagonale \
    [3, 5, 7]   // diagonale /
  ];
  var currentPlayerClass = 'player-'+currentPlayer;
  for (let i = 0; i < winningCombinations.length; i++) {
    const [a, b, c] = winningCombinations[i];
    if (hasClass($('.cell')[a-1], currentPlayerClass) && hasClass(cells[b-1], currentPlayerClass) && hasClass(cells[c-1], currentPlayerClass)) {
      gameOver = true;
      board.classList.add('game-over');
      $("#result").html("Player "+currentPlayer+ " wins");
      $("#result").fadeIn();
      return;
    }
  }
  if (isBoardFull()) {
    gameOver = true;
    board.classList.add('game-over');
    $("#result").html("Draw");
    return;
  }
};

function isBoardFull() {
  for (let i = 0; i < cells.length; i++) {
    if (!cells[i].classList.contains('x') && !cells[i].classList.contains('o')) {
      return false;
    }
  }
  return true;
};

$("#reset").click(function() {
  for (let i = 0; i < cells.length; i++) {
    $('.cell')[i].classList.remove('player-x', 'player-o');
    cells[i].textContent = '';
  }
  board.classList.remove('game-over');
  $("#result").html("&nbsp;");
  gameOver = false;
  currentPlayer = 'x';
});
$('.cell').click(handleCellClick);

