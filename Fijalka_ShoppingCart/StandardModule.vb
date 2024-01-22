Module StandardModule
    ' Global constants for book prices and tax and shipping charges
    Public Const g_decPRINT_I_DID_IT As Decimal = 11.95D
    Public Const g_decPRINT_HISTORY_OF_SCOTLAND As Decimal = 14.5D
    Public Const g_decPRINT_LEARN_CALCULUS As Decimal = 29.95D
    Public Const g_decPRINT_FEEL_THE_STRESS As Decimal = 18.5D
    Public Const g_decAUDIO_LEARN_CALCULUS As Decimal = 29.95D
    Public Const g_decAUDIO_HISTORY_OF_SCOTLAND As Decimal = 14.5D
    Public Const g_decAUDIO_SCIENCE_BODY As Decimal = 12.95D
    Public Const g_decAUDIO_RELAXATION As Decimal = 11.5D

    ' Global constants for sales tax and shipping charge
    Public Const g_decSALES_TAX As Decimal = 0.06D
    Public Const g_decSHIPPING_CHARGE As Decimal = 2D

    ' Global variables for total values for subtotal, tax, shipping, and final total 
    Public g_decSales_Tax_Total As Decimal = 0D
    Public g_decShipping_Total As Decimal = 0D
    Public g_decSubtotal As Decimal = 0D
    Public g_decFinalTotal As Decimal = 0D

    ' Global constants for book titles
    Public Const g_strPrintIDidIt As String = "I Did It Your Way (Print)"
    Public Const g_strPrintTheHistory As String = "The History of Scotland (Print)"
    Public Const g_strPrintLearnCalculus As String = "Learn Calculus in One Day (Print)"
    Public Const g_strPrintFeelTheStress As String = "Feel the Stress (Print)"
    Public Const g_strAudioLearnCalculus As String = "Learn Calculus in One Day (Audio)"
    Public Const g_strAudioTheHistory As String = "The History of Scotland (Audio)"
    Public Const g_strAudioTheScience As String = "The Science of Body Language (Audio)"
    Public Const g_strAudioRelaxation As String = "Relaxation Techniques (Audio)"
End Module
