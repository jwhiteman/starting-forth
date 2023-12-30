( 3 )
: card 21 < if ." under age" else
               ." alcoholic beverages permitted"
            then ;

( 4 )
: sign.test dup 0= if ." zero"     else
            dup 0< if ." negative" else
                      ." positive"
            then then drop ;

( 5 )
: star 42 emit ;
: stars dup 0> if
          0 do star loop
        then ;

( 6  n lo-limit hi-limit -- )
: 3rd.over            rot dup 2swap rot ;
: high.greater.than.n 3rd.over > ;
: 3rd.back            rot rot ;
: low.less.or.equal.n 3rd.back swap <= ;

: my.within high.greater.than.n
            low.less.or.equal.n
            and ;

: my.within rot dup rot swap > rot rot <= and ;

( 7 )
( actual guess -- actual )
: guess 2dup < if ." TOO HIGH" else
        2dup > if ." TOO LOW" else
                  ." CORRECT!" drop
        then then drop ;

( 8 )
: speller abs dup 4 = if ." four"  else
              dup 3 = if ." three" else
              dup 2 = if ." two"   else
              dup 1 = if ." one"   else
              dup 0 = if ." zero"  else
           then then then then then drop ;

( 9 )
( actual low-guess high-guess -- actual | <0> )
: 3rd.over rot dup 2swap rot ;
: top.to.3rd rot rot ;
: 3dup dup 2over rot ;
: 3.equal? 3rd.over = top.to.3rd = and ;

: between.low.and.high? 3rd.over > 3rd.back > and ;

: copy.of.args 3dup ;
: all.equal? 3.equal? ;

: trap copy.of.args between.low.and.high? if ." BETWEEN"          else
       copy.of.args all.equal?            if ." YOU GOT IT!" drop else
                                             ." NOT BETWEEN"
                                          then then drop drop ;
