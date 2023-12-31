( 50 25 100 */ is equal to infix: 50*25 / 100 )
( n m l : star-slash muliplies n*m, and then divides by l )

( to get a percentage, examle: 17% of 217: )
( normal: 217 * 0.17 )
( forth:  217 * 17 / 100 )
( forth:  217 17 100 */ )

( if we want to round up, then do 10 /* first, add 5, and then a final 10 / : )
( note: R% is "rounded percentage" )
: r% 10 */ 5 + 10 / ;


( notes: swap to 'int amt' - because amt will be incremented, int will stay constant )
( notes: 21 1 do -> "from 1 to 20, won't execute on 21 )
: compound  ( amt int -- )
              cr swap 21 1 do ." year " i . 3 spaces
                              2dup r% +  dup ." balance " . cr
                         loop 2drop ;

( 1 )
: stars 0 do ." *" loop ;

( 2 )
( width height -- )
: box 0 do cr dup stars loop
      drop quit ;

( 3 )
: \stars 0 do
           cr i spaces 10 stars
         loop quit ;

( 4 )
: /stars 0 swap do  ( note the swap so that 10 0 becomes 0 10 w/ -1 steps )
                  cr i spaces 10 stars
              -1 +loop quit ;

( 5 )
: /stars-bu begin
              cr dup spaces 10 stars
            1- dup 0= until drop quit ;

( 6 )
( 7 )
( 8 )
