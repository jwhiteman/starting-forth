( n -- sum-from-0-to-n )
: sum 0 swap 0 do i 1+ + loop ;
: fac 1 swap 0 do i 1+ * loop ;
