MOV AH, 02h       
MOV DL, 'H'       
INT 21h

MOV DL, 'i'      
INT 21h

MOV DL, '!'    
INT 21h

MOV DL, 13    
INT 21h
MOV DL, 10      
INT 21h

MOV AH, 01h       
INT 21h            

MOV DL, AL         
MOV AH, 02h        
INT 21h

MOV AH, 4Ch        
INT 21h