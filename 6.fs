( 50 25 100 */ is equal to infix: 50*25 / 100 )
( n m l : star-slash muliplies n*m, and then divides by l )

( to get a percentage, examle: 17% of 217: )
( normal: 217 * 0.17 )
( forth:  217 * 17 / 100 )
( forth:  217 17 100 */ )

( if we want to round up, then do 10 /* first, add 5, and then a final 10 / : )
( note: R% is "rounded percentage" )
: R% 10 */ 5 + 10 / ;


( notes: swap to 'int amt' - because amt will be incremented, int will stay constant )
( notes: 21 1 do -> "from 1 to 20, won't execute on 21 )
: COMPOUND  ( amt int -- )
              CR SWAP 21 1 DO  ." YEAR " I . 3 SPACES
                               2DUP R% +  DUP ." BALANCE " . CR
                         LOOP  2DROP ;
