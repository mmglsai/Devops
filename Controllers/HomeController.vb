﻿Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page.Changed"

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page.Changes"

        Return View()
    End Function
End Class
