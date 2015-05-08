(define (qsort lst)
  (if (> (length lst) 1)
      (let* ((pivot (car lst))
             (tail (cdr lst))
             (left (filter (lambda (v) (<= v pivot)) tail))
             (right (filter (lambda (v) (> v pivot)) tail)))
        (append (qsort left) (list pivot) (qsort right)))
      lst))

(display-line (qsort '(1 3 6 5 7 10 8 2)))
(display-line (qsort '(1 3 3 5 2 1 8 2 1 1 5)))
