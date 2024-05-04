Module Module1
    Public user As Object
    'Calculator Variables
    Public arithmeticprocess As String
    Public countdecimal As Byte
    Public calc_answer As Single
    Public an_operator As Integer
    Public memPlus As Integer
    Public memRecall As Integer
    Public sqrt As Double
    Public sqrt_number As Integer
    Public number1 As Single
    Public number2 As Single

    'MCQ Test
    Public Q_number = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
    Public question = New String() {"What is the cosec (−2/√3}?", "If f : R → R be the function defined by f (x) = x + 5, then f (x) is...?", "Which of the following functions form Z into Z bijections?", "If f: R→ R given by f(x) =(3 − x ), find f0f(x)", "The value of sin [cos (7/25)] is?", "What is the cos-1 (√3/2)...?", "In a LPP, the objective function is always?", "The producer surplus (PS) is?", "The equilibrium point is?", "If sin(x+y)=log(x+y) then dy/dx =...?"}
    Public optionA = New String() {"–π/3", "(x + 5)1/3", "f (x) = x ", "x", " 25/24)", "5π/6", "Quadratic", "₹ 467230", "(95, 16500)", "1"}
    Public optionB = New String() {"27 π/3", "(x – 5)1/3", "f (x) = x + 1", "(3- x )", "25/7", "(π/6", "Cubic", "₹ 451250", "(92, 16000)", "-2"}
    Public optionC = New String() {"π/23", "(5 – x)1/3", "f (x) = 2x + 1", "x", "24/25", "4π/9", "Linear", "₹ 441623", "(90, 17000)", "2"}
    Public optionD = New String() {"5–π/2", "(5 – x)1/3", "f (x) = x + 2", "7/24", "2 power 3", "2π/3", "Biquadratic", "₹ 468564", "(97, 17200)", "-1"}
    Public correct_answer = New String() {"–π/3", "(x – 5)1/3", "f (x) = x + 2", "(3- x )", "24/25", "5π/6", "Linear", "₹ 451250", "(95, 16500)", "-1"}
    Public answer_choosen As String
    Public accumulator1 As Byte
    Public score As Integer
    Public counter As Byte
    Public correct_A As String
    Public Q_count As Byte
End Module
