# Cisco 7945 Config Template

This is a T4 template I created to manage a group of Cisco 7945G IP phones connected to an Asterisk FreePBX phone server.  The XML file can be a bit tricky, so I made this template to simplify the process.  

#### Instructions

Modify the *sample_phones.csv* to fit your needs, then copy the file to C:\Temp with the name *phones.csv*.  Then, simply open the project in Visual Studio, and save the template.  This will product one XML file per line with the proper naming convention of the file, and the correct syntax in the XML. 

#### Other Notes

You will need a FreePBX server, a TFTP, and the ability to set DHCP directives to point the phones to the TFTP.  Instructions for this are beyond the scope of this project, but you can find more information here: https://www.voip-info.org/asterisk-phone-cisco-79xx/

This project is designed to work with the SIP firmware (version 9-4-2SR3-1S).  Older versions may not work properly. 