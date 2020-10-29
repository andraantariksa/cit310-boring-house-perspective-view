Public Class MainForm
    Dim graphics As System.Drawing.Graphics
    Dim streamRead As IO.StreamReader
    Dim file As System.IO.File
    ' Create rectangle. 
    Dim rect As New Rectangle(50, 50, 300, 300)
    Dim Vertex(10, 4) As Double
    Dim lines(15, 2) As PointF
    Dim wt(4, 4) As Double
    Dim vt1To5(4, 4) As Double
    Dim vt7To9(4, 4) As Double
    Dim st(4, 4) As Double
    Dim D(4, 4) As Double
    Dim N(3) As Double
    Dim V(3) As Double
    Dim U(3) As Double

    Sub DrawRect()
        graphics = PictureBox1.CreateGraphics()
        ' Draw rectangle to screen.
        graphics.DrawRectangle(Pens.Black, rect)

    End Sub

    'To set the vertex
    Sub SetVertex(ByRef idx As Integer, ByRef x As Double, ByRef y As Double, ByRef z As Double, ByRef w As Double)
        Vertex(idx, 0) = x
        Vertex(idx, 1) = y
        Vertex(idx, 2) = z
        Vertex(idx, 3) = w
    End Sub


    Sub SetLine2D(ByVal x1 As Double, ByVal y1 As Double, ByVal x2 As Double, ByVal y2 As Double, ByVal idx As Integer)
        lines(idx, 0).X = x1
        lines(idx, 0).Y = y1
        lines(idx, 1).X = x2
        lines(idx, 1).Y = y2
    End Sub

    Function Vecmatmul(ByRef a() As Double, ByRef b(,) As Double) As Double()
        Dim result(3) As Double
        result(0) = a(0) * b(0, 0) + a(1) * b(1, 0) + a(2) * b(2, 0) + a(3) * b(3, 0)
        result(1) = a(0) * b(0, 1) + a(1) * b(1, 1) + a(2) * b(2, 1) + a(3) * b(3, 1)
        result(2) = a(0) * b(0, 2) + a(1) * b(1, 2) + a(2) * b(2, 2) + a(3) * b(3, 2)
        result(3) = a(0) * b(0, 3) + a(1) * b(1, 3) + a(2) * b(2, 3) + a(3) * b(3, 3)
        Return result
    End Function

    'for set returnya jadi matrix (1 x 4)
    Function Mulmat(ByRef a(,) As Double, ByRef b(,) As Double, ByRef d As Integer) As Double()
        Dim result(4) As Double
        result(0) = a(d, 0) * b(0, 0) + a(d, 1) * b(1, 0) + a(d, 2) * b(2, 0) + a(d, 3) * b(3, 0)
        result(1) = a(d, 0) * b(0, 1) + a(d, 1) * b(1, 1) + a(d, 2) * b(2, 1) + a(d, 3) * b(3, 1)
        result(2) = a(d, 0) * b(0, 2) + a(d, 1) * b(1, 2) + a(d, 2) * b(2, 2) + a(d, 3) * b(3, 2)
        result(3) = a(d, 0) * b(0, 3) + a(d, 1) * b(1, 3) + a(d, 2) * b(2, 3) + a(d, 3) * b(3, 3)
        Return result
    End Function


    Sub setrow(ByRef m(,) As Double, ByRef row As Integer, ByRef a As Double, ByRef b As Double, ByRef c As Double, ByRef d As Double)
        m(row, 0) = a
        m(row, 1) = b
        m(row, 2) = c
        m(row, 3) = d
    End Sub

    Sub ResetView()
        graphics = PictureBox1.CreateGraphics()

        'set dot
        SetVertex(0, -1, -1, 1, 1)
        SetVertex(1, 1, -1, 1, 1)
        SetVertex(2, 1, 0, 1, 1)
        SetVertex(3, 0, 1, 1, 1)
        SetVertex(4, -1, 0, 1, 1)
        SetVertex(5, -1, -1, -1, 1)
        SetVertex(6, 1, -1, -1, 1)
        SetVertex(7, 1, 0, -1, 1)
        SetVertex(8, 0, 1, -1, 1)
        SetVertex(9, -1, 0, -1, 1)

        'wt matrix
        setrow(wt, 0, 1, 0, 0, 0)
        setrow(wt, 1, 0, 1, 0, 0)
        setrow(wt, 2, 0, 0, 1, 0)
        setrow(wt, 3, 0, 0, 0, 1)

        'vt matrix
        setrow(vt1To5, 0, 1, 0, 0, 0)
        setrow(vt1To5, 1, 0, 1, 0, 0)
        setrow(vt1To5, 2, 0, 0, 0, 0)
        setrow(vt1To5, 3, 0, 0, 0, 1)

        'st matrix
        setrow(st, 0, 150, 0, 0, 0)
        setrow(st, 1, 0, -150, 0, 0)
        setrow(st, 2, 0, 0, 0, 0)
        setrow(st, 3, 200, 200, 0, 1)
    End Sub

    Sub ResetGUI()
        vrpx.Text = 0
        vrpy.Text = 0
        vrpz.Text = 0
        vpnx.Text = 0
        vpny.Text = 0
        vpnz.Text = 1
        vUPx.Text = 0
        vUPy.Text = 1
        vUPz.Text = 0
        copx.Text = 0
        copy.Text = 0
        copz.Text = 4
        umin.Text = -2
        vmin.Text = -2
        umax.Text = 2
        vmax.Text = 2
        TextBox18.Text = 2
        TextBox17.Text = -10
    End Sub

    Sub Reset()
        ResetGUI()
        ResetView()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()

        'Set Vertex
        SetVertex(0, -1, -1, 1, 1)
        SetVertex(1, 1, -1, 1, 1)
        SetVertex(2, 1, 0, 1, 1)
        SetVertex(3, 0, 1, 1, 1)
        SetVertex(4, -1, 0, 1, 1)
        SetVertex(5, -1, -1, -1, 1)
        SetVertex(6, 1, -1, -1, 1)
        SetVertex(7, 1, 0, -1, 1)
        SetVertex(8, 0, 1, -1, 1)
        SetVertex(9, -1, 0, -1, 1)

        'wt matrix
        setrow(wt, 0, 1, 0, 0, 0)
        setrow(wt, 1, 0, 1, 0, 0)
        setrow(wt, 2, 0, 0, 1, 0)
        setrow(wt, 3, 0, 0, 0, 1)

        'vt matrix
        setrow(vt1To5, 0, 1, 0, 0, 0)
        setrow(vt1To5, 1, 0, 1, 0, 0)
        setrow(vt1To5, 2, 0, 0, 0, 0)
        setrow(vt1To5, 3, 0, 0, 0, 1)

        'st matrix
        setrow(st, 0, 150, 0, 0, 0)
        setrow(st, 1, 0, -150, 0, 0)
        setrow(st, 2, 0, 0, 0, 0)
        setrow(st, 3, 200, 200, 0, 1)

        'setVertex(10, 1, -1, -1, 1)
        'setVertex(11, 1, 0, -1, 1)
        'setVertex(12, 0, 1, -1, 1)
        'setVertex(13, -1, 0, -1, 1)
    End Sub

    'Sub Draw(ByVal n As Integer, ByVal f As Integer)
    '    For i = 5 To 14
    '        Dim vertex1 = lines(i, 0)
    '        System.Console.WriteLine("X=" & vertex1.X & " Y=" & vertex1.Y)
    '        If Single.IsInfinity(vertex1.X) Or Single.IsInfinity(vertex1.Y) Then
    '            Continue For
    '        End If
    '        Dim vertex2 = lines(i, 1)
    '        If Single.IsInfinity(vertex2.X) Or Single.IsInfinity(vertex2.Y) Then
    '            Continue For
    '        End If
    '        graphics.DrawLine(Pens.Black, vertex1, vertex2)
    '    Next

    '    For i = 0 To 4
    '        Dim vertex1 = lines(i, 0)
    '        If Single.IsInfinity(vertex1.X) Or Single.IsInfinity(vertex1.Y) Then
    '            Continue For
    '        End If
    '        Dim vertex2 = lines(i, 1)
    '        If Single.IsInfinity(vertex2.X) Or Single.IsInfinity(vertex2.Y) Then
    '            Continue For
    '        End If
    '        graphics.DrawLine(Pens.Red, vertex1, vertex2)
    '    Next
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim T1T2(4, 4), T3(4, 4), T4(4, 4), T5(4, 4) As Double
        Dim T7(4, 4), T8(4, 4), T9(4, 4) As Double
        Dim A(4, 4) As Double
        Dim VRP(3), VPN(3), VUP(3), COP(3) As Double
        Dim window(4), FP, BP, h, w As Double
        Dim vertexConnection(15, 2) As Integer

        vertexConnection = {{0, 1}, {1, 2}, {2, 3},
            {3, 4}, {4, 0}, {5, 6}, {6, 7},
            {7, 8}, {8, 9}, {9, 5}, {0, 5},
            {1, 6}, {2, 7}, {3, 8}, {4, 9}}

        VRP(0) = CDbl(vrpx.Text)
        VRP(1) = CDbl(vrpy.Text)
        VRP(2) = CDbl(vrpz.Text)

        VPN(0) = CDbl(vpnx.Text)
        VPN(1) = CDbl(vpny.Text)
        VPN(2) = CDbl(vpnz.Text)

        VUP(0) = CDbl(vUPx.Text)
        VUP(1) = CDbl(vUPy.Text)
        VUP(2) = CDbl(vUPz.Text)

        COP(0) = CDbl(copx.Text)
        COP(1) = CDbl(copy.Text)
        COP(2) = CDbl(copz.Text)

        window(0) = CDbl(umin.Text)
        window(1) = CDbl(vmin.Text)
        window(2) = CDbl(umax.Text)
        window(3) = CDbl(vmax.Text)

        FP = CDbl(TextBox18.Text)
        BP = CDbl(TextBox17.Text)

        UVN(VPN, VUP)

        Dim rprime(3) As Double
        rprime(0) = ((-VRP(0) * U(0)) + (-VRP(1) * U(1)) + (-VRP(2) * U(2)))
        rprime(1) = ((-VRP(0) * V(0)) + (-VRP(1) * V(1)) + (-VRP(2) * V(2)))
        rprime(2) = ((-VRP(0) * N(0)) + (-VRP(1) * N(1)) + (-VRP(2) * N(2)))

        setrow(T1T2, 0, U(0), V(0), N(0), 0)
        setrow(T1T2, 1, U(1), V(1), N(1), 0)
        setrow(T1T2, 2, U(2), V(2), N(2), 0)
        setrow(T1T2, 3, rprime(0), rprime(1), rprime(2), 1)

        setrow(T3, 0, 1, 0, 0, 0)
        setrow(T3, 1, 0, 1, 0, 0)
        setrow(T3, 2, 0, 0, 1, 0)
        setrow(T3, 3, -COP(0), -COP(1), -COP(2), 1)

        Dim CW(3) As Double
        CW(0) = (window(2) + window(0)) / 2
        CW(1) = (window(3) + window(1)) / 2
        CW(2) = -COP(2)

        Dim DOPx = (CW(0) - COP(0))
        Dim DOPy = (CW(1) - COP(1))
        Dim DOPz = (CW(2) - COP(2))

        Dim shearX = DOPx / DOPz
        Dim shearY = DOPy / DOPz

        setrow(T4, 0, 1, 0, 0, 0)
        setrow(T4, 1, 0, 1, 0, 0)
        setrow(T4, 2, -shearX, -shearY, 1, 0)
        setrow(T4, 3, 0, 0, 0, 1)

        w = ((COP(2) - BP) * (window(2) - window(0))) / (2 * COP(2))
        h = ((COP(2) - BP) * (window(3) - window(1))) / (2 * COP(2))

        setrow(T5, 0, 1 / w, 0, 0, 0)
        setrow(T5, 1, 0, 1 / h, 0, 0)
        setrow(T5, 2, 0, 0, (-1 / (BP - COP(2))), 0)
        setrow(T5, 3, 0, 0, 0, 1)

        'T6 clipping

        setrow(T7, 0, 1, 0, 0, 0)
        setrow(T7, 1, 0, 1, 0, 0)
        setrow(T7, 2, 0, 0, 1, 0)
        setrow(T7, 3, 0, 0, -(-COP(2) / (COP(2) - BP)), 1)

        setrow(T8, 0, (COP(2) - BP) / COP(2), 0, 0, 0)
        setrow(T8, 1, 0, (COP(2) - BP) / COP(2), 0, 0)
        setrow(T8, 2, 0, 0, 1, 0)
        setrow(T8, 3, 0, 0, 0, 1)

        setrow(T9, 0, 1, 0, 0, 0)
        setrow(T9, 1, 0, 1, 0, 0)
        setrow(T9, 2, 0, 0, 1, (-1 / (COP(2) / (COP(2) - BP))))
        setrow(T9, 3, 0, 0, 0, 1)

        vt1To5 = Mulmat4x4(Mulmat4x4(Mulmat4x4(T1T2, T3), T4), T5)
        vt7To9 = Mulmat4x4(Mulmat4x4(T7, T8), T9)


        Clear()
        DrawRect()

        TransformAndDraw(Vertex, vertexConnection, 10, 15, FP, BP, COP)

    End Sub
    Sub UVN(ByVal a() As Double, ByVal b() As Double)
        Dim UP(3), dot As Double
        Dim UPprime(3) As Double

        'N
        N(0) = (1 / (Math.Sqrt((a(0) * a(0)) + (a(1) * a(1)) + (a(2) * a(2)))) * a(0))
        N(1) = (1 / (Math.Sqrt((a(0) * a(0)) + (a(1) * a(1)) + (a(2) * a(2)))) * a(1))
        N(2) = (1 / (Math.Sqrt((a(0) * a(0)) + (a(1) * a(1)) + (a(2) * a(2)))) * a(2))

        'up
        UP(0) = (1 / (Math.Sqrt((b(0) * b(0)) + (b(1) * b(1)) + (b(2) * b(2)))) * b(0))
        UP(1) = (1 / (Math.Sqrt((b(0) * b(0)) + (b(1) * b(1)) + (b(2) * b(2)))) * b(1))
        UP(2) = (1 / (Math.Sqrt((b(0) * b(0)) + (b(1) * b(1)) + (b(2) * b(2)))) * b(2))

        'dot product of up and N
        dot = (UP(0) * N(0)) + (UP(1) * N(1)) + (UP(2) * N(2))

        'up'
        UPprime(0) = UP(0) - (dot * N(0))
        UPprime(1) = UP(1) - (dot * N(1))
        UPprime(2) = UP(2) - (dot * N(2))

        'V
        V(0) = (1 / (Math.Sqrt((UPprime(0) * UPprime(0)) + (UPprime(1) * UPprime(1)) + (UPprime(2) * UPprime(2)))) * UPprime(0))
        V(1) = (1 / (Math.Sqrt((UPprime(0) * UPprime(0)) + (UPprime(1) * UPprime(1)) + (UPprime(2) * UPprime(2)))) * UPprime(1))
        V(2) = (1 / (Math.Sqrt((UPprime(0) * UPprime(0)) + (UPprime(1) * UPprime(1)) + (UPprime(2) * UPprime(2)))) * UPprime(2))

        'U
        U(0) = (V(1) * N(2)) - (N(1) * V(2))
        U(1) = (V(2) * N(0)) - (N(2) * V(0))
        U(2) = (V(0) * N(1)) - (N(0) * V(1))
    End Sub

    Function Line3Parametric(ByVal a As Double(), ByVal b As Double(), ByVal t As Double) As Double()
        Return New Double() {
            a(0) + (t * (b(0) - a(0))),
            a(1) + (t * (b(1) - a(1))),
            a(2) + (t * (b(2) - a(2)))
        }
    End Function

    Function Vec3Sub(ByVal vecA As Double(), ByVal vecB As Double()) As Double()
        Return New Double() {
            vecA(0) - vecB(0),
            vecA(1) - vecB(1),
            vecA(2) - vecB(2)
        }
    End Function

    Function Vec3Dot(ByVal vecA As Double(), ByVal vecB As Double()) As Double
        Return vecA(0) * vecB(0) + vecA(1) * vecB(1) + vecA(2) * vecB(2)
    End Function

    Function FindTCyrusBeck(ByVal point1 As Double(), ByVal point2 As Double(), ByVal arbitraryPoint As Double(), ByVal vecNormal As Double()) As Double
        Dim vecAP(3) As Double
        Dim vecAB(3) As Double
        vecAP = Vec3Sub(arbitraryPoint, point1)
        vecAB = Vec3Sub(point2, point1)

        Return Vec3Dot(vecAP, vecNormal) / Vec3Dot(vecAB, vecNormal)
    End Function

    Function ClipCyrusBeck(ByVal P1 As Double(), ByVal P2 As Double(), ByVal FP As Double, ByVal BP As Double, ByVal COP As Double()) As Double()()
        Dim normalFront = New Double() {0.0, 0.0, -1.0}
        Dim normalBack = New Double() {0.0, 0.0, 1.0}
        Dim normalLeft = New Double() {1.0, 0.0, -1.0}
        Dim normalRight = New Double() {-1.0, 0.0, -1.0}
        Dim normalTop = New Double() {0.0, -1.0, -1.0}
        Dim normalBottom = New Double() {0.0, 1.0, -1.0}
        Dim planeNormals = New Double()() {normalFront, normalLeft, normalBack, normalRight, normalTop, normalBottom}

        Dim pointOnPlaneFront = New Double() {0.0, 0.0, (FP - COP(2)) / (COP(2) - BP)}
        Dim pointOnPlaneBack = New Double() {0.0, 0.0, -1.0}
        Dim pointOnPlaneLeft = New Double() {0.0, 0.0, 0.0}
        Dim pointOnPlaneRight = New Double() {0.0, 0.0, 0.0}
        Dim pointOnPlaneTop = New Double() {0.0, 0.0, 0.0}
        Dim pointOnPlaneBottom = New Double() {0.0, 0.0, 0.0}
        Dim planeNormalsArbitraryPoint = New Double()() {pointOnPlaneFront, pointOnPlaneLeft, pointOnPlaneBack, pointOnPlaneRight, pointOnPlaneTop, pointOnPlaneBottom}

        Dim entering = New List(Of Double)
        Dim leaving = New List(Of Double)

        Dim P1res = New Double(3) {}
        Array.Copy(P1, P1res, 3)
        Dim P2res = New Double(3) {}
        Array.Copy(P2, P2res, 3)

        Dim maxTEntering = 0.0
        Dim minTLeaving = 1.0

        For i = 0 To 5
            Dim normal = planeNormals(i)
            Dim arbitraryPoint = planeNormalsArbitraryPoint(i)

            Dim dotProdP1 = Vec3Dot(Vec3Sub(P1, planeNormalsArbitraryPoint(i)), normal)
            Dim dotProdP2 = Vec3Dot(Vec3Sub(P2, planeNormalsArbitraryPoint(i)), normal)

            If dotProdP1 > 0.0 And dotProdP2 > 0.0 Then
                ' Trivial accepted
                ' Do nothing
            ElseIf dotProdP1 < 0.0 And dotProdP2 < 0.0 Then
                ' Trivial reject
                Return Nothing
            Else
                If dotProdP1 < 0.0 And dotProdP2 >= 0.0 Then
                    Dim t = FindTCyrusBeck(P1res, P2res, arbitraryPoint, normal)
                    If t > maxTEntering Then
                        maxTEntering = t
                    End If
                ElseIf dotProdP1 >= 0.0 And dotProdP2 < 0.0 Then
                    Dim t = FindTCyrusBeck(P1res, P2res, arbitraryPoint, normal)
                    If t < minTLeaving Then
                        minTLeaving = t
                    End If
                End If
            End If
        Next

        If maxTEntering < minTLeaving Then
            P1res = Line3Parametric(P1, P2, maxTEntering)
            P2res = Line3Parametric(P1, P2, minTLeaving)
            Return New Double()() {P1res, P2res}
        Else
            Return Nothing
        End If
    End Function

    Structure TVertex
        Dim X As Double
        Dim Y As Double
        Dim Z As Double
        Dim W As Double
    End Structure

    Structure TLine
        Dim Vertex1 As TVertex
        Dim Vertex2 As TVertex
        Dim Color As Pen
    End Structure

    Sub TransformAndDraw(ByVal p(,) As Double, ByVal vertexConnection(,) As Integer, ByVal pointTotal As Integer, ByVal linen As Integer, ByVal FP As Double, ByVal BP As Double, ByVal COP As Double())
        Dim vertexResult(pointTotal, 4) As Double
        Dim temp(4) As Double
        For i = 0 To pointTotal - 1
            temp = Mulmat(Vertex, wt, i)
            vertexResult(i, 0) = temp(0)
            vertexResult(i, 1) = temp(1)
            vertexResult(i, 2) = temp(2)
            vertexResult(i, 3) = temp(3)
            temp = Mulmat(vertexResult, vt1To5, i)
            vertexResult(i, 0) = temp(0)
            vertexResult(i, 1) = temp(1)
            vertexResult(i, 2) = temp(2)
            vertexResult(i, 3) = temp(3)
        Next

        Dim lines(linen - 1) As TLine

        For i = 0 To linen - 1
            ' First 5 edge are the front face
            lines(i).Color = If(i < 5, Pens.Red, Pens.Black)

            lines(i).Vertex1.X = vertexResult(vertexConnection(i, 0), 0)
            lines(i).Vertex1.Y = vertexResult(vertexConnection(i, 0), 1)
            lines(i).Vertex1.Z = vertexResult(vertexConnection(i, 0), 2)
            lines(i).Vertex1.W = vertexResult(vertexConnection(i, 0), 3)

            lines(i).Vertex2.X = vertexResult(vertexConnection(i, 1), 0)
            lines(i).Vertex2.Y = vertexResult(vertexConnection(i, 1), 1)
            lines(i).Vertex2.Z = vertexResult(vertexConnection(i, 1), 2)
            lines(i).Vertex2.W = vertexResult(vertexConnection(i, 1), 3)
        Next

        'Clipping
        For i = 0 To linen - 1
            Dim resLines = ClipCyrusBeck(
                    New Double() {lines(i).Vertex1.X, lines(i).Vertex1.Y, lines(i).Vertex1.Z},
                    New Double() {lines(i).Vertex2.X, lines(i).Vertex2.Y, lines(i).Vertex2.Z},
                    FP,
                    BP,
                    COP)

            If Not resLines Is Nothing Then
                ' Vertex 1

                lines(i).Vertex1.X = resLines(0)(0)
                lines(i).Vertex1.Y = resLines(0)(1)
                lines(i).Vertex1.Z = resLines(0)(2)

                Dim v(3) As Double
                v(0) = lines(i).Vertex1.X
                v(1) = lines(i).Vertex1.Y
                v(2) = lines(i).Vertex1.Z
                v(3) = lines(i).Vertex1.W

                v = Vecmatmul(Vecmatmul(v, vt7To9), st)

                v(0) = v(0) / v(3)
                v(1) = v(1) / v(3)

                ' Vertex 2
                lines(i).Vertex2.X = resLines(1)(0)
                lines(i).Vertex2.Y = resLines(1)(1)
                lines(i).Vertex2.Z = resLines(1)(2)

                Dim v2(3) As Double
                v2(0) = lines(i).Vertex2.X
                v2(1) = lines(i).Vertex2.Y
                v2(2) = lines(i).Vertex2.Z
                v2(3) = lines(i).Vertex2.W

                v2 = Vecmatmul(Vecmatmul(v2, vt7To9), st)

                v2(0) = v2(0) / v2(3)
                v2(1) = v2(1) / v2(3)

                ' Draw
                If Double.IsNaN(v(0)) Or Double.IsInfinity(v(0)) Or Double.IsNaN(v2(0)) Or Double.IsInfinity(v2(0)) Then
                    Continue For
                End If

                Dim p1 As Point
                p1.X = v(0)
                p1.Y = v(1)

                Dim p2 As Point
                p2.X = v2(0)
                p2.Y = v2(1)

                graphics.DrawLine(lines(i).Color, p1, p2)
            End If
        Next
        'End clipping
    End Sub

    Function Mulmat4x4(ByVal a(,) As Double, ByVal b(,) As Double) As Double(,)
        Dim result(4, 4) As Double
        result(0, 0) = a(0, 0) * b(0, 0) + a(0, 1) * b(1, 0) + a(0, 2) * b(2, 0) + a(0, 3) * b(3, 0)
        result(0, 1) = a(0, 0) * b(0, 1) + a(0, 1) * b(1, 1) + a(0, 2) * b(2, 1) + a(0, 3) * b(3, 1)
        result(0, 2) = a(0, 0) * b(0, 2) + a(0, 1) * b(1, 2) + a(0, 2) * b(2, 2) + a(0, 3) * b(3, 2)
        result(0, 3) = a(0, 0) * b(0, 3) + a(0, 1) * b(1, 3) + a(0, 2) * b(2, 3) + a(0, 3) * b(3, 3)
        result(1, 0) = a(1, 0) * b(0, 0) + a(1, 1) * b(1, 0) + a(1, 2) * b(2, 0) + a(1, 3) * b(3, 0)
        result(1, 1) = a(1, 0) * b(0, 1) + a(1, 1) * b(1, 1) + a(1, 2) * b(2, 1) + a(1, 3) * b(3, 1)
        result(1, 2) = a(1, 0) * b(0, 2) + a(1, 1) * b(1, 2) + a(1, 2) * b(2, 2) + a(1, 3) * b(3, 2)
        result(1, 3) = a(1, 0) * b(0, 3) + a(1, 1) * b(1, 3) + a(1, 2) * b(2, 3) + a(1, 3) * b(3, 3)
        result(2, 0) = a(2, 0) * b(0, 0) + a(2, 1) * b(1, 0) + a(2, 2) * b(2, 0) + a(2, 3) * b(3, 0)
        result(2, 1) = a(2, 0) * b(0, 1) + a(2, 1) * b(1, 1) + a(2, 2) * b(2, 1) + a(2, 3) * b(3, 1)
        result(2, 2) = a(2, 0) * b(0, 2) + a(2, 1) * b(1, 2) + a(2, 2) * b(2, 2) + a(2, 3) * b(3, 2)
        result(2, 3) = a(2, 0) * b(0, 3) + a(2, 1) * b(1, 3) + a(2, 2) * b(2, 3) + a(2, 3) * b(3, 3)
        result(3, 0) = a(3, 0) * b(0, 0) + a(3, 1) * b(1, 0) + a(3, 2) * b(2, 0) + a(3, 3) * b(3, 0)
        result(3, 1) = a(3, 0) * b(0, 1) + a(3, 1) * b(1, 1) + a(3, 2) * b(2, 1) + a(3, 3) * b(3, 1)
        result(3, 2) = a(3, 0) * b(0, 2) + a(3, 1) * b(1, 2) + a(3, 2) * b(2, 2) + a(3, 3) * b(3, 2)
        result(3, 3) = a(3, 0) * b(0, 3) + a(3, 1) * b(1, 3) + a(3, 2) * b(2, 3) + a(3, 3) * b(3, 3)

        Return result
    End Function

    Sub Clear()
        PictureBox1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reset()
        Button1.PerformClick()
    End Sub

    Private Sub btnDeflt_Click(sender As Object, e As EventArgs) Handles btnDeflt.Click

    End Sub

    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        Reset()
        Clear()
        Dim txtimg As String

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            txtimg = OpenFileDialog1.FileName
            Dim fileReader As New System.IO.StreamReader(txtimg)

            Do While fileReader.Peek() <> -1

                Dim str1, str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, str15 As String
                Dim str16, str17, str18, str19, str20, str21, str22, str23, str24, str25, str26, str27, str28, str29, str30 As String


                str1 = fileReader.ReadLine
                str2 = fileReader.ReadLine
                str3 = fileReader.ReadLine
                str4 = fileReader.ReadLine
                str5 = fileReader.ReadLine
                str6 = fileReader.ReadLine
                str7 = fileReader.ReadLine
                str8 = fileReader.ReadLine
                str9 = fileReader.ReadLine
                str10 = fileReader.ReadLine
                str11 = fileReader.ReadLine
                str12 = fileReader.ReadLine
                str13 = fileReader.ReadLine
                str14 = fileReader.ReadLine
                str15 = fileReader.ReadLine
                str16 = fileReader.ReadLine
                str17 = fileReader.ReadLine
                str18 = fileReader.ReadLine
                str19 = fileReader.ReadLine
                str20 = fileReader.ReadLine
                str21 = fileReader.ReadLine
                str22 = fileReader.ReadLine
                str23 = fileReader.ReadLine
                str24 = fileReader.ReadLine
                str25 = fileReader.ReadLine
                str26 = fileReader.ReadLine
                str27 = fileReader.ReadLine
                str28 = fileReader.ReadLine
                str29 = fileReader.ReadLine
                str30 = fileReader.ReadLine

                SetVertex(0, CDbl(str1), CDbl(str2), CDbl(str3), 1)
                SetVertex(1, CDbl(str4), CDbl(str5), CDbl(str6), 1)
                SetVertex(2, CDbl(str7), CDbl(str8), CDbl(str9), 1)
                SetVertex(3, CDbl(str10), CDbl(str11), CDbl(str12), 1)
                SetVertex(4, CDbl(str13), CDbl(str14), CDbl(str15), 1)
                SetVertex(5, CDbl(str16), CDbl(str17), CDbl(str18), 1)
                SetVertex(6, CDbl(str19), CDbl(str20), CDbl(str21), 1)
                SetVertex(7, CDbl(str22), CDbl(str23), CDbl(str24), 1)
                SetVertex(8, CDbl(str25), CDbl(str26), CDbl(str27), 1)
                SetVertex(9, CDbl(str28), CDbl(str29), CDbl(str30), 1)

                Button1.PerformClick()

            Loop
        End If
    End Sub
End Class
