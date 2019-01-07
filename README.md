# Workflow

1. User runs the game and gets default balance - **$1000** (or different value?). Balance sets to default every time the game runs.
2. User choose an amount of money he/she wants to put among available options: **[$1, $5, $25, $50, $100]**
3. User choose one of available bet options:
    * specific number in range 0-36
    *  all red
    *  all black
    * all even
    * all odd
    * 1st 12 (range 1-12)
    * 2nd 12 (range 13-24)
    * 3rd 12 (range 25-36)
    * 1st 18 (range 1-18)*
    * 2nd 18 (range 19-36)*
4. User press "Spin" button
5. Creates an object of class "Bet" that contains amount of money and slot (a number, all black, all even, etc.)
6. Object of class Table
    1. gets that bet object
    2. executes method SpinRoulette() that randomly generates a number
    3. compares result of spinRoulette() method and the bet.
    4. executes method IsWin() that show an alert with result (win or lost)
7. Updates balance
  
