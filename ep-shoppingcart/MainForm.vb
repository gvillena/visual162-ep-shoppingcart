Public Class MainForm

    Private SeccionHombres As Boolean = False
    Private SeccionMujeres As Boolean = False
    Private SeccionCalzado As Boolean = False
    Private SeccionAccesorios As Boolean = False

    Private IndiceLista As Integer = 0

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Habilitando Seccion Hombres
        SeccionHombres = True
        SeccionMujeres = False
        SeccionCalzado = False
        SeccionAccesorios = False

        ' Inicializnado Indice Lista
        IndiceLista = 1

        ' Actualizando Titulo Seccion
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black

        ' Actualizando Titulo y Precio
        lblTitulo.Text = "Eng Poplin Shirt"
        lblPrecio.Text = "$85"

        ' Actualizando Lista de Imagenes
        pbProdL1.Image = My.Resources.Resources.h_01_01_small
        pbProdL2.Image = My.Resources.Resources.h_01_02_small
        pbProdL3.Image = My.Resources.Resources.h_01_03_small
        pbProdL4.Image = My.Resources.Resources.h_01_04_small

        ' Actualizando Imagen Normal
        pbProducto.Image = My.Resources.Resources.h_01_01_normal

        ' Actualizando Tallas
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver

        ' Reiniciando Cantidad
        txtCantidad.Text = "1"

        ' Deshabilitando btnLeft
        btnLeft.Enabled = False

        ' Habilitando btnTrue
        btnRight.Enabled = True


    End Sub

    Private Sub btnHombres_Click(sender As Object, e As EventArgs) Handles btnHombres.Click

        ' Habilitando Seccion Hombres
        SeccionHombres = True
        SeccionMujeres = False
        SeccionCalzado = False
        SeccionAccesorios = False

        ' Reiniciando Indice Lista
        IndiceLista = 1

        ' Actualizando Titulo Seccion
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black

        ' Actualizando Titulo y Precio
        lblTitulo.Text = "Eng Poplin Shirt"
        lblPrecio.Text = "$85"

        ' Actualizando Lista de Imagenes
        pbProdL1.Image = My.Resources.Resources.h_01_01_small
        pbProdL2.Image = My.Resources.Resources.h_01_02_small
        pbProdL3.Image = My.Resources.Resources.h_01_03_small
        pbProdL4.Image = My.Resources.Resources.h_01_04_small

        ' Actualizando Imagen Normal
        pbProducto.Image = My.Resources.Resources.h_01_01_normal

        ' Actualizando Tallas
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver

        ' Reiniciando Cantidad
        txtCantidad.Text = "1"

        ' Deshabilitando btnLeft
        btnLeft.Enabled = False

        ' Habilitando btnTrue
        btnRight.Enabled = True



    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click

        ' Habilitando Seccion Hombres
        SeccionHombres = False
        SeccionMujeres = True
        SeccionCalzado = False
        SeccionAccesorios = False

        ' Reiniciando Indice Lista
        IndiceLista = 1

        ' Actualizando Titulo Seccion
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
        btnAccesorios.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black

        ' Actualizando Titulo y Precio
        lblTitulo.Text = "Nicola Blouse"
        lblPrecio.Text = "$120"

        ' Actualizando Lista de Imagenes
        pbProdL1.Image = My.Resources.Resources.m_01_01_small
        pbProdL2.Image = My.Resources.Resources.m_01_02_small
        pbProdL3.Image = My.Resources.Resources.m_01_03_small
        pbProdL4.Image = My.Resources.Resources.m_01_04_small

        ' Actualizando Imagen Normal
        pbProducto.Image = My.Resources.Resources.m_01_01_normal

        ' Actualizando Tallas
        lblTallaP1.Text = "XS"
        lblTallaP1.ForeColor = Color.Silver
        lblTallaP2.Text = "S"
        lblTallaP2.ForeColor = Color.Black
        lblTallaP3.Text = "M"
        lblTallaP3.ForeColor = Color.Black
        lblTallaP4.Text = "L"
        lblTallaP4.ForeColor = Color.Black
        lblTallaP5.Text = "XL"
        lblTallaP5.ForeColor = Color.Silver

        ' Reiniciando Cantidad
        txtCantidad.Text = "1"

        ' Deshabilitando btnLeft
        btnLeft.Enabled = False

        ' Habilitando btnTrue
        btnRight.Enabled = True

    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click

        ' Habilitando Seccion Calzado
        SeccionHombres = False
        SeccionMujeres = False
        SeccionCalzado = True
        SeccionAccesorios = False

        ' Reiniciando Indice Lista
        IndiceLista = 1

        ' Actualizando Titulo Seccion
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.SteelBlue
        btnAccesorios.ForeColor = Color.Black

        ' Actualizando Titulo y Precio
        lblTitulo.Text = "Philip 1d Triners"
        lblPrecio.Text = "$55"

        ' Actualizando Lista de Imagenes
        pbProdL1.Image = My.Resources.Resources.c_01_01_small
        pbProdL2.Image = My.Resources.Resources.c_01_02_small
        pbProdL3.Image = My.Resources.Resources.c_01_03_small
        pbProdL4.Image = My.Resources.Resources.c_01_04_small

        ' Actualizando Imagen Normal
        pbProducto.Image = My.Resources.Resources.c_01_01_normal

        ' Actualizando Tallas
        lblTallaP1.Text = "37"
        lblTallaP1.ForeColor = Color.Silver
        lblTallaP2.Text = "38"
        lblTallaP2.ForeColor = Color.Black
        lblTallaP3.Text = "40"
        lblTallaP3.ForeColor = Color.Black
        lblTallaP4.Text = "41"
        lblTallaP4.ForeColor = Color.Black
        lblTallaP5.Text = "42"
        lblTallaP5.ForeColor = Color.Silver

        ' Reiniciando Cantidad
        txtCantidad.Text = "1"

        ' Deshabilitando btnLeft
        btnLeft.Enabled = False

        ' Habilitando btnTrue
        btnRight.Enabled = True

    End Sub

    Private Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click

        ' Habilitando Seccion Accesorios
        SeccionHombres = False
        SeccionMujeres = False
        SeccionCalzado = False
        SeccionAccesorios = True

        ' Reiniciando Indice Lista
        IndiceLista = 1

        ' Actualizando Titulo Seccion
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.SteelBlue

        ' Actualizando Titulo y Precio
        lblTitulo.Text = "Strap Watch 1971"
        lblPrecio.Text = "$175"

        ' Actualizando Lista de Imagenes
        pbProdL1.Image = My.Resources.Resources.a_01_01_small
        pbProdL2.Image = Nothing
        pbProdL3.Image = Nothing
        pbProdL4.Image = Nothing

        ' Actualizando Imagen Normal
        pbProducto.Image = My.Resources.Resources.a_01_01_normal

        ' Actualizando Tallas
        lblTallaP1.Text = "-"
        lblTallaP1.ForeColor = Color.Silver
        lblTallaP2.Text = "-"
        lblTallaP2.ForeColor = Color.Silver
        lblTallaP3.Text = "-"
        lblTallaP3.ForeColor = Color.Silver
        lblTallaP4.Text = "-"
        lblTallaP4.ForeColor = Color.Silver
        lblTallaP5.Text = "-"
        lblTallaP5.ForeColor = Color.Silver

        ' Reiniciando Cantidad
        txtCantidad.Text = "1"

        ' Deshabilitando btnLeft
        btnLeft.Enabled = False

        ' Habilitando btnTrue
        btnRight.Enabled = True

    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click

        ' Actualizando Indice Lista
        IndiceLista -= 1

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Eng Poplin Shirt"
                        lblPrecio.Text = "$85"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.h_01_01_small
                        pbProdL2.Image = My.Resources.Resources.h_01_02_small
                        pbProdL3.Image = My.Resources.Resources.h_01_03_small
                        pbProdL4.Image = My.Resources.Resources.h_01_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.h_01_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Plaited Sub Cashmere Blend Jumper"
                        lblPrecio.Text = "$110"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.h_02_01_small
                        pbProdL2.Image = My.Resources.Resources.h_02_02_small
                        pbProdL3.Image = My.Resources.Resources.h_02_03_small
                        pbProdL4.Image = My.Resources.Resources.h_02_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.h_02_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Cotton Linen V-Neck Jumper"
                        lblPrecio.Text = "$95"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.h_03_01_small
                        pbProdL2.Image = My.Resources.Resources.h_03_02_small
                        pbProdL3.Image = My.Resources.Resources.h_03_03_small
                        pbProdL4.Image = My.Resources.Resources.h_03_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.h_03_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Nicola Blouse"
                        lblPrecio.Text = "$120"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.m_01_01_small
                        pbProdL2.Image = My.Resources.Resources.m_01_02_small
                        pbProdL3.Image = My.Resources.Resources.m_01_03_small
                        pbProdL4.Image = My.Resources.Resources.m_01_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.m_01_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Jezma Blazer"
                        lblPrecio.Text = "$190"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.m_02_01_small
                        pbProdL2.Image = My.Resources.Resources.m_02_02_small
                        pbProdL3.Image = My.Resources.Resources.m_02_03_small
                        pbProdL4.Image = My.Resources.Resources.m_02_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.m_02_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Neige Dress"
                        lblPrecio.Text = "$125"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.m_03_01_small
                        pbProdL2.Image = My.Resources.Resources.m_03_02_small
                        pbProdL3.Image = Nothing
                        pbProdL4.Image = Nothing

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.m_03_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Philip 1d Trainers"
                        lblPrecio.Text = "$55"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.c_01_01_small
                        pbProdL2.Image = My.Resources.Resources.c_01_02_small
                        pbProdL3.Image = My.Resources.Resources.c_01_03_small
                        pbProdL4.Image = My.Resources.Resources.c_01_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.c_01_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Deck 4d Mixed"
                        lblPrecio.Text = "$80"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.c_02_01_small
                        pbProdL2.Image = My.Resources.Resources.c_02_02_small
                        pbProdL3.Image = My.Resources.Resources.c_02_03_small
                        pbProdL4.Image = My.Resources.Resources.c_02_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.c_02_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Parson 8n Mid Heel"
                        lblPrecio.Text = "$155"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.c_03_01_small
                        pbProdL2.Image = My.Resources.Resources.c_03_02_small
                        pbProdL3.Image = My.Resources.Resources.c_03_03_small
                        pbProdL4.Image = My.Resources.Resources.c_03_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.c_03_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionAccesorios

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Strap Watch 1791"
                        lblPrecio.Text = "$175"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.a_01_01_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.a_01_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft y Habilitando btnRight
                        btnLeft.Enabled = False
                        btnRight.Enabled = True

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Classic Logo Red Cap"
                        lblPrecio.Text = "$25"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.a_02_01_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.a_02_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y Deshabilitando btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = False

                End Select
        End Select


    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click

        ' Actualizando Indice Lista
        IndiceLista += 1

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Eng Poplin Shirt"
                        lblPrecio.Text = "$85"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.h_01_01_small
                        pbProdL2.Image = My.Resources.Resources.h_01_02_small
                        pbProdL3.Image = My.Resources.Resources.h_01_03_small
                        pbProdL4.Image = My.Resources.Resources.h_01_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.h_01_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Plaited Sub Cashmere Blend Jumper"
                        lblPrecio.Text = "$110"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.h_02_01_small
                        pbProdL2.Image = My.Resources.Resources.h_02_02_small
                        pbProdL3.Image = My.Resources.Resources.h_02_03_small
                        pbProdL4.Image = My.Resources.Resources.h_02_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.h_02_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnLeft.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Cotton Linen V-Neck Jumper"
                        lblPrecio.Text = "$95"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.h_03_01_small
                        pbProdL2.Image = My.Resources.Resources.h_03_02_small
                        pbProdL3.Image = My.Resources.Resources.h_03_03_small
                        pbProdL4.Image = My.Resources.Resources.h_03_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.h_03_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Nicola Blouse"
                        lblPrecio.Text = "$120"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.m_01_01_small
                        pbProdL2.Image = My.Resources.Resources.m_01_02_small
                        pbProdL3.Image = My.Resources.Resources.m_01_03_small
                        pbProdL4.Image = My.Resources.Resources.m_01_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.m_01_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Jezma Blazer"
                        lblPrecio.Text = "$190"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.m_02_01_small
                        pbProdL2.Image = My.Resources.Resources.m_02_02_small
                        pbProdL3.Image = My.Resources.Resources.m_02_03_small
                        pbProdL4.Image = My.Resources.Resources.m_02_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.m_02_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnLeft.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Neige Dress"
                        lblPrecio.Text = "$125"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.m_03_01_small
                        pbProdL2.Image = My.Resources.Resources.m_03_02_small
                        pbProdL3.Image = Nothing
                        pbProdL4.Image = Nothing

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.m_03_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Philip 1d Trainers"
                        lblPrecio.Text = "$55"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.c_01_01_small
                        pbProdL2.Image = My.Resources.Resources.c_01_02_small
                        pbProdL3.Image = My.Resources.Resources.c_01_03_small
                        pbProdL4.Image = My.Resources.Resources.c_01_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.c_01_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft
                        btnLeft.Enabled = False

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Deck 4d Mixed"
                        lblPrecio.Text = "$80"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.c_02_01_small
                        pbProdL2.Image = My.Resources.Resources.c_02_02_small
                        pbProdL3.Image = My.Resources.Resources.c_02_03_small
                        pbProdL4.Image = My.Resources.Resources.c_02_04_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.c_02_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y btnRight
                        btnLeft.Enabled = True
                        btnLeft.Enabled = True

                    Case 3

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Parson 8n Mid Heel"
                        lblPrecio.Text = "$155"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.c_03_01_small
                        pbProdL2.Image = My.Resources.Resources.c_03_02_small
                        pbProdL3.Image = My.Resources.Resources.c_03_03_small
                        pbProdL4.Image = My.Resources.Resources.c_03_04_small

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.c_03_01_normal

                        ' Deshabilitando btnRight
                        btnRight.Enabled = False

                End Select

            Case SeccionAccesorios

                Select Case IndiceLista

                    Case 1

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Strap Watch 1791"
                        lblPrecio.Text = "$175"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.a_01_01_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.a_01_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Deshabilitando btnLeft y Habilitando btnRight
                        btnLeft.Enabled = False
                        btnRight.Enabled = True

                    Case 2

                        ' Actualizando Titulo y Precio 
                        lblTitulo.Text = "Classic Logo Red Cap"
                        lblPrecio.Text = "$25"

                        ' Actualizando Lista de Imagenes
                        pbProdL1.Image = My.Resources.Resources.a_02_01_small

                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.a_02_01_normal

                        ' Actualizando Cantidad
                        txtCantidad.Text = "1"

                        ' Habilitando btnLeft y Deshabilitando btnRight
                        btnLeft.Enabled = True
                        btnRight.Enabled = False

                End Select
        End Select

    End Sub

    Private Sub pbProdL1_Click(sender As Object, e As EventArgs) Handles pbProdL1.Click

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.h_01_01_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.h_02_01_normal

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.h_03_01_normal

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.m_01_01_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.m_02_01_normal

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.m_03_01_normal

                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.c_01_01_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.c_02_01_normal

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.c_03_01_normal

                End Select

            Case SeccionAccesorios

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.a_01_01_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.a_02_01_normal

                End Select
        End Select

    End Sub

    Private Sub pbProdL2_Click(sender As Object, e As EventArgs) Handles pbProdL2.Click

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.h_01_02_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.h_02_02_normal

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.h_03_02_normal

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.m_01_02_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.m_02_02_normal

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.m_03_02_normal

                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.c_01_02_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.c_02_02_normal

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.c_03_02_normal

                End Select

        End Select

    End Sub

    Private Sub pbProdL3_Click(sender As Object, e As EventArgs) Handles pbProdL3.Click

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.h_01_03_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.h_02_03_normal

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.h_03_03_normal

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.m_01_03_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.m_02_03_normal


                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.c_01_03_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.c_02_03_normal

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.c_03_03_normal

                End Select

        End Select

    End Sub

    Private Sub pbProdL4_Click(sender As Object, e As EventArgs) Handles pbProdL4.Click

        Select Case True

            Case SeccionHombres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.h_01_04_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.h_02_04_normal

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.h_03_04_normal

                End Select

            Case SeccionMujeres

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.m_01_04_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.m_02_04_normal

                End Select

            Case SeccionCalzado

                Select Case IndiceLista

                    Case 1
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.c_01_04_normal

                    Case 2
                        ' Actualizando Imagen Normal 
                        pbProducto.Image = My.Resources.Resources.c_02_04_normal

                    Case 3
                        ' Actualizando Imagen Normal
                        pbProducto.Image = My.Resources.Resources.c_03_04_normal

                End Select

        End Select

    End Sub

End Class