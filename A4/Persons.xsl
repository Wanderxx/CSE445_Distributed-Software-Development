<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="/"> 
	<html> <body>
        <h1>Persons</h1> 
          <table border="1">        
            <tr bgcolor="yellow"> 
	            <td><b>Name/First</b></td>
	            <td><b>Name/Last</b></td>
	            <td><b>Credential/Id</b></td>
	            <td><b>Credential/Password</b></td>
              <td><b>Password/Encryption</b></td>   
	            <td><b>Phone/Work</b></td>
	            <td><b>Phone/Cell</b></td> 
              <td><b>Provider</b></td>  
	            <td><b>Category</b></td> 
	            
            </tr>
            <xsl:for-each select="Persons/Person">
                 <xsl:sort select="Name" />
                 <tr style="font-size: 10pt; font-family: verdana">
                      <td><xsl:value-of select="Name/First"/></td>
                      <td><xsl:value-of select="Name/Last"/></td>
                      <td><xsl:value-of select="Credential/Id"/></td> 
                      <td><xsl:value-of select="Credential/Password"/></td>  
                      <td><xsl:value-of select="Credential/Password/@Encryption"/></td>                   
                      <td><xsl:value-of select="Phone/Work"/></td> 
                      <td><xsl:value-of select="Phone/Cell"/></td> 
                      <td><xsl:value-of select="Phone/Cell/@Provider"/></td>
                      <td><xsl:value-of select="Category"/></td> 
                 </tr> 
            </xsl:for-each>
          </table> 
    </body> </html>
</xsl:template> 
</xsl:stylesheet>