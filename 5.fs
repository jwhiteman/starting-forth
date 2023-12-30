( 1 )
( a b c -- )
: ex5.1 rot negate rot * swap / ;

( 2 )
( 6 70 123 45 -- )
: max4 max >R  ( first max pair, store in R )
       max     ( second max pair )
       R> max  ( compare max of first w/ second )
       dup .   ( dup the winner, print )
       ;

( 3 )
32 32 - 10 18 */
212 32 - 10 18 */
-32 32 - 10 18 */
16 18 10 */ 32 +
233 273 -

( 4 )
: F>C 32 - 10 18 */ ;
: F>K F>C 273 + ;
: C>F 18 10 */ 32 + ;
: C>K 273 + ;
: K>C 273 - ;
: K>F K>C C>F ;
