function show_hide_layer(lname)
{
	if (lname != null) {
	lname.style.display = 'none';
	}
}

if (!bResolution) 
	show_hide_layer(document.getElementById('resolution'));

if (!bQuality) 
	show_hide_layer(document.getElementById('quality'));

if (!bImage) 
	show_hide_layer(document.getElementById('image_mode'));

if (!bColor)
	show_hide_layer(document.getElementById('color_mode'));

if (!bDarkness)
	show_hide_layer(document.getElementById('darkness'));

if (!bTonersave)
	show_hide_layer(document.getElementById('Toner_Save'));

if (!bReprint)
	show_hide_layer(document.getElementById('Reprint'));
	
if (!bHighaltitude)
	show_hide_layer(document.getElementById('High_Altitude'));

if (!bPowersave)
	show_hide_layer(document.getElementById('Power_Save'));

if (!bAboutButtons)
	show_hide_layer(document.getElementById('About_page_buttons'));
	
if (!bPaper)
	show_hide_layer(document.getElementById('Paper_page'));	

if (!bJobProof)
	show_hide_layer(document.getElementById('Job_Proof'));	

if (!bBlackOptimization)
	show_hide_layer(document.getElementById('BlackOptimization'));	

if (!bPageColorSetting)
	show_hide_layer(document.getElementById('PageColorSetting'));	

if (!bJobAccountingEncryption)
	show_hide_layer(document.getElementById('Job_Accounting_Encryption'));	