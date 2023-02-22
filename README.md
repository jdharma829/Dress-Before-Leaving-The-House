# Dress Before Leaving The House

## Problem: You must get fully dressed before leaving the house

### Rules:
- At the start, assume you have PJ’s on
- Only 1 piece of each item of clothing may be put on
- You cannot put on socks when it is hot
- You cannot put on jacket when it is hot
- Socks must be put on before footwear
- Shirt must be put on before headwear and jacket
- Pants must be put on before footwear
- Pajamas must be taken off before anything can be put on
- You cannot leave the house until all items of clothing are on (except socks and a jacket when it’s hot)
- If an invalid command is issued, please respond with “fail”

### Input: Temperature type (HOT|COLD) and a comma separated list of numeric commands

Command |&nbsp;Description&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;Hot Response&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;Cold Response <br/>
___________________________________________________________________________ <br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;Put on footwear&nbsp;&nbsp;|&nbsp;“sandals”&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;“boots” <br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;Put on headwear&nbsp;|&nbsp;“sunglasses”&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;“hat” <br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;3&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;Put on socks&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;fail&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;“socks” <br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;4&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;Put on shirt&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;“shirt”&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;“shirt” <br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;5&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;Put on jacket&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;fail&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;“jacket” <br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;6&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;Put on pants&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;“shorts”&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;“pants” <br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;7&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;Leave house&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;“leaving house”&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;“leaving house” <br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;8&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;Take off pajamas&nbsp;|&nbsp;“Removing PJs”&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;“Removing PJs” <br/>

### Here are some example scenarios

### Successful
-----------------------------------------------------------------------------<br/>
Input: HOT 8, 6, 4, 2, 1, 7 <br/>
Output: Removing PJs, shorts, shirt, sunglasses, sandals, leaving house <br/> <br/>

Input: COLD 8, 6, 3, 4, 2, 5, 1, 7 <br/>
Output: Removing PJs, pants, socks, shirt, hat, jacket, boots, leaving house <br/> <br/>

### Failure
-----------------------------------------------------------------------------<br/>
Input: HOT 7 <br/>
Output: failure <br/><br/>

Input: HOT 8, 6, 6 <br/>
Output: Removing PJs, shorts, fail <br/><br/>

Input: HOT 8, 6, 3 <br/>
Output: Removing PJs, shorts, fail <br/><br/>

Input: COLD 8, 6, 3, 4, 2, 5, 7 <br/>
Output: Removing PJs, pants, socks, shirt, hat, jacket, fail <br/><br/>

Input: COLD 8, 6, 3, 4, 2, 5, 1 <br/>
Output: Removing PJs, pants, socks, shirt, hat, jacket, boots, fail <br/><br/>

Input: COLD 6 <br/>
Output: fail <br/><br/>
