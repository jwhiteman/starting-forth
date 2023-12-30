( *** Quizzie 2-a )

( 1. a b + c * )
3 4 + 2 * . ( 14 )

( 2. \(3a - b\) / 4 + c )
7 3 * 1 - 4 / 5 + . ( 10 )

( 3. 0.5 ab / 100 )
0.5 2 3 * * 100 / . ( 0 )

( 4. \(n + 1\) / n )
1 1 + 1 / . ( 2 )

( 5. x\(7x + 5\) )
( x 7 x * 5 + * )
2 7 2 * 5 + * . ( 38 )

( 6. \(a - b\) / \(b + a\) )
( 7. a / \(b * 10\) )

( *** Quizzie 2-b )

( 1. ba + c )
: 2B1 * + ; ( c b a -- result )

( 2. \(a - 4b\) / 6 + c )
: 2B2 4 * - 6 / + ; ( c a b -- result )
2 40 1 2B2 . ( 8 )

( 3. a / \(8b\) )
: 2B3 8 * / ; ( a b -- result )
64 1 2B3 . ( 8 ) 

( 4.  2 ab /  7)
: 2B4  * 2 * 7 / ; ( a b -- result )
7 3 2B4 . ( 6 )

( 5. a\(2a + 3\) )
: 2B5 dup 2 * 3 + * ; ( a -- result )
5 2B5 . ( 65 )

( 6. \(a - b\) / c )
( 
  This is the issue: the divisor - c in this case - needs to be at the top of the stack.
  However 'a b -' needs to be done first, which also means it needs to be at the top of the stack.
  So some stack manipulations are in order, so that all stack elements can have their time
  to shine towards the top of the stack to receive their needed operations.
)
: 2B6 - swap / ; ( c a b -- result )
3 7 1 2B6 . ( 2 )

( *** Quizzie 2-c )
( 1. a b c   becomes c b a )
1 2 3 rot rot swap .s

( 2. a b -- a b a , but without using OVER )
1 2 swap dup rot rot .s

clearstack

( 3. a b c -- c a b )
1 2 3 rot rot .s

( 4. )
: 2C1 dup 1 + swap / ;             ( n -- \(n+1\) / n )
: 2C2 dup 7 * 5 + * ;              ( x -- x\(7x + 5\) )
: 2C3 over dup * 9 * rot rot * - ; ( a b -- 9a2 - ba )

( chapter end problems )

( 1. DUP DUP copies the top of the stack, twice. 2DUP copies the top 2 entries once )
( 2.  \( 1 2 3 4 -- 4 3 2 1 \) )
1 2 3 4 swap 2swap swap .s

( 3. 3dup \( 1 2 3 -- 1 2 3 1 2 3 \) )
: 3dup dup 2over rot ;

( 4. a2 + ab + c \( c a b -- result \) )
: 2e4 over + * + ;
11 3 7 2e4 .s ( 41 )

( 5. \(a-b\) / \(a+b\)  \( a b -- result \) )
3 -1 2dup + rot rot - swap / .s ( 2 )

( 6. this is actually pretty awesome: )
: CONVICTED-OF 0 ;
: HOMOCIDE 20 + ;
: ARSON 10 + ;
: BOOKMAKING 2 + ;
: TAX-EVASION 5 + ;
: WILL-SERVE  . ." years." ;

CONVICTED-OF HOMOCIDE ARSON TAX-EVASION
WILL-SERVE
clearstack

( 7. )
: eggs.to.cartons 12 /mod ." is " . ." dozen eggs with "  . ." left over." ;
