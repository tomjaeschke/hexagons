<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Damisam.UserInterface.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>an endless grid of hexagons which alternate color and spiral outwards from a central point</title>
    <link href='StyleSheet.css' media='screen, projection' rel='stylesheet' type='text/css' />
</head>
<body>
    <form id="damisam" runat="server">
        <div class="summary">
            <div class="download">
                <div class="float">Source Code:</div>
                <div class="float link"><a href="https://github.com/tomjaeschke/hexagons">GIT</a></div>
                <div class="float link"><a href="https://github.com/tomjaeschke/hexagons/archive/master.zip">ZIP</a></div>
            </div>
            <div>
                <asp:Label ID="Instructions" runat="server" Text="enter a positive integer of up to five digits"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
                <asp:Button ID="Button" runat="server" Text="Submit" OnClick="Button_Click" />
            </div>
            <div>
                <h1><span class="subh1">HEXAGON</span> <asp:Label ID="Hexagon" runat="server" Text=""></asp:Label></h1>
                <table border="0">
                    <tr>
                        <td align="right">Color:</td>
                        <td nowrap><asp:Label ID="Color" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td nowrap align="right">Hexagon To East:</td>
                        <td nowrap><asp:Label ID="HexagonToTheEast" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td nowrap align="right">Hexagon To South By Southeast:</td>
                        <td nowrap><asp:Label ID="HexagonToTheSouthBySoutheast" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td nowrap align="right">Hexagon To South By Southwest:</td>
                        <td nowrap><asp:Label ID="HexagonToTheSouthBySouthwest" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td nowrap align="right">Hexagon To West:</td>
                        <td nowrap><asp:Label ID="HexagonToTheWest" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td nowrap align="right">Hexagon To North By Northwest: </td>
                        <td nowrap><asp:Label ID="HexagonToTheNorthByNorthwest" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td nowrap align="right">Hexagon To North By Northeast:</td>
                        <td nowrap><asp:Label ID="HexagonToTheNorthByNortheast" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="instructions" align="center" nowrap>click the arrows to navigate -></td>
                        <td class="instructions"></td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="maininterface">
            <div class="<%=Model.Color%>" style="margin-left: 290px; margin-top: 179px;"><%=Model.Hexagon%></div>
            <div class="<%=Model.ColorOfHexagonToTheEast%>" style="margin-left: 390px; margin-top: 179px;"><%=Model.HexagonToTheEast%></div>
            <div class="<%=Model.ColorOfHexagonToTheSouthBySoutheast%>" style="margin-left: 340px; margin-top: 265px;"><%=Model.HexagonToTheSouthBySoutheast%></div>
            <div class="<%=Model.ColorOfHexagonToTheSouthBySouthwest%>" style="margin-left: 240px; margin-top: 265px;"><%=Model.HexagonToTheSouthBySouthwest%></div>
            <div class="<%=Model.ColorOfHexagonToTheWest%>" style="margin-left: 190px; margin-top: 179px;"><%=Model.HexagonToTheWest%></div>
            <div class="<%=Model.ColorOfHexagonToTheNorthByNorthwest%>" style="margin-left: 240px; margin-top: 93px;"><%=Model.HexagonToTheNorthByNorthwest%></div>
            <div class="<%=Model.ColorOfHexagonToTheNorthByNortheast%>" style="margin-left: 340px; margin-top: 93px;"><%=Model.HexagonToTheNorthByNortheast%></div>
            <div onclick="window.location='Default.aspx?moveby=arrow&hexagon=<%=Model.HexagonToTheEast%>'" class="arroweast" style="margin-left: 490px; margin-top: 179px;"></div>
            <div onclick="window.location='Default.aspx?moveby=arrow&hexagon=<%=Model.HexagonToTheSouthBySoutheast%>'" class="arrowsouthbysoutheast" style="margin-left: 390px; margin-top: 351px;"></div>
            <div onclick="window.location='Default.aspx?moveby=arrow&hexagon=<%=Model.HexagonToTheSouthBySouthwest%>'" class="arrowsouthbysouthwest" style="margin-left: 190px; margin-top: 351px;"></div>
            <div onclick="window.location='Default.aspx?moveby=arrow&hexagon=<%=Model.HexagonToTheWest%>'" class="arrowwest" style="margin-left: 90px; margin-top: 179px;"></div>
            <div onclick="window.location='Default.aspx?moveby=arrow&hexagon=<%=Model.HexagonToTheNorthByNorthwest%>'" class="arrownorthbynorthwest" style="margin-left: 190px; margin-top: 7px;"></div>
            <div onclick="window.location='Default.aspx?moveby=arrow&hexagon=<%=Model.HexagonToTheNorthByNortheast%>'" class="arrownorthbynortheast" style="margin-left: 390px; margin-top: 7px;"></div>
        </div>
        <div class="introduction">
            I have built an endless grid of hexagons which alternate color and spiral outwards from a central point. Why did I build this? I had an idea for an online game in which players could control hexagons and invade from one hexagon to another. I envisioned allowing everyone to play and thus I needed an endlessly huge grid of hexagons that could scale, scale, scale. Eventually, I realized that my idea for a game wasn't a good idea and thus I am just publishing the magic I wrote around the hexagons which I am proud of. Enjoy. On a chessboard (a grid of squares), two colors are used in a pattern ensuring that no two squares of the same color are ever adjacent. A comparable trick may be done to ensure that no two hexagons of the same color are adjacent on a grid of hexagons if three colors are used. The code uses no database. All magic is done by calculation. I'm Tom Jaeschke of Austin, Texas. Please contact me with any questions at: tomjaeschke@tomjaeschke.com
        </div>
        <div class="directions">
            <div class="sweet" style="margin-left: 590px; margin-top: 179px;">0</div>
            <div class="sour" style="margin-left: 690px; margin-top: 179px;">1</div>
            <div class="salty" style="margin-left: 640px; margin-top: 265px;">2</div>
            <div class="sour" style="margin-left: 540px; margin-top: 265px;">3</div>
            <div class="salty" style="margin-left: 490px; margin-top: 179px;">4</div>
            <div class="sour" style="margin-left: 540px; margin-top: 93px;">5</div>
            <div class="salty" style="margin-left: 640px; margin-top: 93px;">6</div>
            <div class="sweet" style="margin-left: 740px; margin-top: 93px;">7</div>
            <div class="salty" style="margin-left: 790px; margin-top: 179px;">8</div>
            <div class="sweet" style="margin-left: 740px; margin-top: 265px;">9</div>
            <div class="sour" style="margin-left: 690px; margin-top: 351px;">10</div>
            <div class="sweet" style="margin-left: 590px; margin-top: 351px;">11</div>
            <div class="salty" style="margin-left: 490px; margin-top: 351px;">12</div>
            <div class="sweet" style="margin-left: 440px; margin-top: 265px;">13</div>
            <div class="sour" style="margin-left: 390px; margin-top: 179px;">14</div>
            <div class="sweet" style="margin-left: 440px; margin-top: 93px;">15</div>
            <div class="salty" style="margin-left: 490px; margin-top: 7px;">16</div>
            <div class="sweet" style="margin-left: 590px; margin-top: 7px;">17</div>
            <div class="sour" style="margin-left: 690px; margin-top: 7px;">18</div>
            <div class="salty" style="margin-left: 790px; margin-top: 7px;">19</div>
            <div class="sour" style="margin-left: 840px; margin-top: 93px;">20</div>
            <div class="sweet" style="margin-left: 890px; margin-top: 179px;">21</div>
            <div class="sour" style="margin-left: 840px; margin-top: 265px;">22</div>
            <div class="salty" style="margin-left: 790px; margin-top: 351px;">23</div>
            <div class="sweet" style="margin-left: 740px; margin-top: 437px;">24</div>
            <div class="salty" style="margin-left: 640px; margin-top: 437px;">25</div>
            <div class="sour" style="margin-left: 540px; margin-top: 437px;">26</div>
            <div class="swirl"></div>
        </div>
        <div class="copy">
            How it works: Imagine the configuration for bowling ball pins. The first row has one pin, the second row as two pins, the third row has three pins, and, yes, the fourth row has four pins. What if there were ten rows. That would make fifty-five pins. How do I get the number fifty-five? It comes from multiplying the number of rows (10) by a number one greater (11) and then dividing by two. So what row would pin forty-two sit upon? Things get a little bit trickier when trying to reverse engineer how a position corresponds to a row, but I'm sure you can see that it may be done. Pin forty-two would sit on row nine. I make hexagons manifest in rings around a hexagon zero (shown in the center below). The rings have a relationship to their contents very comparable to the relationship rows of bowling ball pins have with their contents. For example, just as I may guarantee mathematically that pin forty-two sits on row nine, I may likewise guarantee that hexagon forty-two sits on ring four as shown below. The difference between rings and rows is that a ring will hold a quantity of hexagons equivalent to its number multiplied by six instead of a quantity merely equivalent to its number. Ring one has six hexagons, ring two has twelve hexagons, ring three has eighteen hexagons, ring four has twenty-four hexagons, and so on.
        </div>
        <div class="note">
            <div class="sweet" style="margin-left: 450px; margin-top: 351px;">0</div>
            <div class="sweet" style="margin-left: 600px; margin-top: 265px;">7</div>
            <div class="salty" style="margin-left: 650px; margin-top: 351px;">8</div>
            <div class="sweet" style="margin-left: 600px; margin-top: 437px;">9</div>
            <div class="sour" style="margin-left: 550px; margin-top: 523px;">10</div>
            <div class="sweet" style="margin-left: 450px; margin-top: 523px;">11</div>
            <div class="salty" style="margin-left: 350px; margin-top: 523px;">12</div>
            <div class="sweet" style="margin-left: 300px; margin-top: 437px;">13</div>
            <div class="sour" style="margin-left: 250px; margin-top: 351px;">14</div>
            <div class="sweet" style="margin-left: 300px; margin-top: 265px;">15</div>
            <div class="salty" style="margin-left: 350px; margin-top: 179px;">16</div>
            <div class="sweet" style="margin-left: 450px; margin-top: 179px;">17</div>
            <div class="sour" style="margin-left: 550px; margin-top: 179px;">18</div>
            <div class="sour" style="margin-left: 700px; margin-top: 93px;">37</div>
            <div class="sweet" style="margin-left: 750px; margin-top: 179px;">38</div>
            <div class="salty" style="margin-left: 800px; margin-top: 265px;">39</div>
            <div class="sour" style="margin-left: 850px; margin-top: 351px;">40</div>
            <div class="salty" style="margin-left: 800px; margin-top: 437px;">41</div>
            <div class="sweet" style="margin-left: 750px; margin-top: 523px;">42</div>
            <div class="sour" style="margin-left: 700px; margin-top: 609px;">43</div>
            <div class="salty" style="margin-left: 650px; margin-top: 695px;">44</div>
            <div class="sour" style="margin-left: 550px; margin-top: 695px;">45</div>
            <div class="sweet" style="margin-left: 450px; margin-top: 695px;">46</div>
            <div class="salty" style="margin-left: 350px; margin-top: 695px;">47</div>
            <div class="sour" style="margin-left: 250px; margin-top: 695px;">48</div>
            <div class="salty" style="margin-left: 200px; margin-top: 609px;">49</div>
            <div class="sweet" style="margin-left: 150px; margin-top: 523px;">50</div>
            <div class="sour" style="margin-left: 100px; margin-top: 437px;">51</div>
            <div class="salty" style="margin-left: 50px; margin-top: 351px;">52</div>
            <div class="sour" style="margin-left: 100px; margin-top: 265px;">53</div>
            <div class="sweet" style="margin-left: 150px; margin-top: 179px;">54</div>
            <div class="salty" style="margin-left: 200px; margin-top: 93px;">55</div>
            <div class="sour" style="margin-left: 250px; margin-top: 7px;">56</div>
            <div class="salty" style="margin-left: 350px; margin-top: 7px;">57</div>
            <div class="sweet" style="margin-left: 450px; margin-top: 7px;">58</div>
            <div class="sour" style="margin-left: 550px; margin-top: 7px;">59</div>
            <div class="salty" style="margin-left: 650px; margin-top: 7px;">60</div>
        </div>
        <div class="copy">
            Rings two and four are shown above and rings one and three are shown below. All ring numbers are important for determining a hexagon's position relative to hexagon zero at the center of our spiral. Ring three, and every ring divisible evenly by three, is important for another reason. Every third ring offers colors for their hexagons in an easy-to-predict repetitive pattern.
        </div>
        <div class="note">
            <div class="sour" style="margin-left: 550px; margin-top: 351px;">1</div>
            <div class="salty" style="margin-left: 500px; margin-top: 437px;">2</div>
            <div class="sour" style="margin-left: 400px; margin-top: 437px;">3</div>
            <div class="salty" style="margin-left: 350px; margin-top: 351px;">4</div>
            <div class="sour" style="margin-left: 400px; margin-top: 265px;">5</div>
            <div class="salty" style="margin-left: 500px; margin-top: 265px;">6</div>            
            <div class="salty" style="margin-left: 650px; margin-top: 179px;">19</div>
            <div class="sour" style="margin-left: 700px; margin-top: 265px;">20</div>
            <div class="sweet" style="margin-left: 750px; margin-top: 351px;">21</div>
            <div class="sour" style="margin-left: 700px; margin-top: 437px;">22</div>
            <div class="salty" style="margin-left: 650px; margin-top: 523px;">23</div>
            <div class="sweet" style="margin-left: 600px; margin-top: 609px;">24</div>
            <div class="salty" style="margin-left: 500px; margin-top: 609px;">25</div>
            <div class="sour" style="margin-left: 400px; margin-top: 609px;">26</div>
            <div class="sweet" style="margin-left: 300px; margin-top: 609px;">27</div>
            <div class="sour" style="margin-left: 250px; margin-top: 523px;">28</div>
            <div class="salty" style="margin-left: 200px; margin-top: 437px;">29</div>
            <div class="sweet" style="margin-left: 150px; margin-top: 351px;">30</div>
            <div class="salty" style="margin-left: 200px; margin-top: 265px;">31</div>
            <div class="sour" style="margin-left: 250px; margin-top: 179px;">32</div>
            <div class="sweet" style="margin-left: 300px; margin-top: 93px;">33</div>
            <div class="sour" style="margin-left: 400px; margin-top: 93px;">34</div>
            <div class="salty" style="margin-left: 500px; margin-top: 93px;">35</div>
            <div class="sweet" style="margin-left: 600px; margin-top: 93px;">36</div>
        </div>
        <div class="copy">
            How do we know what colors the other hexagons are? Well, to jump ahead a little bit, the knowledge that I find vital to hold for any one hexagon beyond its number and color is the numeric values of its six neighbors. If one cannot determine that hexagon fourteen sits to the West of hexagon four then the positions in space of hexagons fourteen and four and their proximity to hexagon zero are meaningless. The relative position of any one hexagon on our endless spiral of hexagons can only exist by being relative to something else. Now that I've said that, if one knows the neighbors of a hexagon not on a third ring and also the ring number of the hexagon not on a third ring, one will almost always be able to find two neighbors on an adjacent third ring. In gauging the colors of the two neighbors (which will always be different as the two neighbors will always be touching and two adjacent hexagons may not share the same color) one may, by default, determine the color of the hexagon NOT on the third ring by knowing that it is the color that the other two colors are not. Remember, there are only three colors and no two adjacent hexagons have the same color. Hexagons on ring two may look outward from the center of the spiral to find hexagons on ring three in the name of this calculation. Hexagons on ring four may look inwards towards the spiral's center to find hexagons on ring three in the name of this calculation. There are two exceptions where this rule does not work. Firstly, I had to just "hard code" the colors for the first seven hexagons as they are not adjacent to a third ring hexagon. Secondly, the ring outside a third ring will have six hexagons that only have one neighbor on the third ring as seen below. These guys have to have their colors calculated differently, but they nonetheless fall into an easy to calculate pattern as you can probably see for yourself.
        </div>
        <div class="note">            
            <div class="salty" style="margin-left: 650px; margin-top: 179px;">19</div>
            <div class="sour" style="margin-left: 700px; margin-top: 265px;">20</div>
            <div class="sweet" style="margin-left: 750px; margin-top: 351px;">21</div>
            <div class="sour" style="margin-left: 700px; margin-top: 437px;">22</div>
            <div class="salty" style="margin-left: 650px; margin-top: 523px;">23</div>
            <div class="sweet" style="margin-left: 600px; margin-top: 609px;">24</div>
            <div class="salty" style="margin-left: 500px; margin-top: 609px;">25</div>
            <div class="sour" style="margin-left: 400px; margin-top: 609px;">26</div>
            <div class="sweet" style="margin-left: 300px; margin-top: 609px;">27</div>
            <div class="sour" style="margin-left: 250px; margin-top: 523px;">28</div>
            <div class="salty" style="margin-left: 200px; margin-top: 437px;">29</div>
            <div class="sweet" style="margin-left: 150px; margin-top: 351px;">30</div>
            <div class="salty" style="margin-left: 200px; margin-top: 265px;">31</div>
            <div class="sour" style="margin-left: 250px; margin-top: 179px;">32</div>
            <div class="sweet" style="margin-left: 300px; margin-top: 93px;">33</div>
            <div class="sour" style="margin-left: 400px; margin-top: 93px;">34</div>
            <div class="salty" style="margin-left: 500px; margin-top: 93px;">35</div>
            <div class="sweet" style="margin-left: 600px; margin-top: 93px;">36</div>
            <div class="sour" style="margin-left: 850px; margin-top: 351px;">40</div>
            <div class="salty" style="margin-left: 650px; margin-top: 695px;">44</div>
            <div class="sour" style="margin-left: 250px; margin-top: 695px;">48</div>
            <div class="salty" style="margin-left: 50px; margin-top: 351px;">52</div>
            <div class="sour" style="margin-left: 250px; margin-top: 7px;">56</div>
            <div class="salty" style="margin-left: 650px; margin-top: 7px;">60</div>
        </div>
        <div class="copy">
            Why do six hexagons on ring four not have two neighboring hexagons on ring three? The rings are not circular. The rings themselves are of a hexagonal shape, holding six corners. The outliers happen at the corners. Given that the rings are hexagonal, they thus have six segments running in six different directions. In determining the neighbors of a given hexagon, one must calculate which segment of a ring one is upon. The specificity of which segment one is upon may be used to determine if the hexagon to the West is on the same ring, the ring just outside the current ring, or the ring just inside the current ring. If on the same ring, the neighbor to the West will merely have a number one greater or one smaller than that of the hexagon from which we started. If we are looking into another ring, we may find the number of the hexagon to the West by finding a hexagon that sits in more or less the same position as our first hexagon on the other ring. Much of my code calculates the relative position of two hexagons in roughly the same spot on two separate rings. Below, ring three is broken up so that you may see its six distinct segments.
        </div>
        <div class="note">
            <div class="salty" style="margin-left: 700px; margin-top: 93px;">19</div>
            <div class="sour" style="margin-left: 750px; margin-top: 179px;">20</div>
            <div class="sweet" style="margin-left: 800px; margin-top: 265px;">21</div>
            <div class="sour" style="margin-left: 800px; margin-top: 437px;">22</div>
            <div class="salty" style="margin-left: 750px; margin-top: 523px;">23</div>
            <div class="sweet" style="margin-left: 700px; margin-top: 609px;">24</div>
            <div class="salty" style="margin-left: 550px; margin-top: 695px;">25</div>
            <div class="sour" style="margin-left: 450px; margin-top: 695px;">26</div>
            <div class="sweet" style="margin-left: 350px; margin-top: 695px;">27</div>
            <div class="sour" style="margin-left: 200px; margin-top: 609px;">28</div>
            <div class="salty" style="margin-left: 150px; margin-top: 523px;">29</div>
            <div class="sweet" style="margin-left: 100px; margin-top: 437px;">30</div>
            <div class="salty" style="margin-left: 100px; margin-top: 265px;">31</div>
            <div class="sour" style="margin-left: 150px; margin-top: 179px;">32</div>
            <div class="sweet" style="margin-left: 200px; margin-top: 93px;">33</div>
            <div class="sour" style="margin-left: 350px; margin-top: 7px;">34</div>
            <div class="salty" style="margin-left: 450px; margin-top: 7px;">35</div>
            <div class="sweet" style="margin-left: 550px; margin-top: 7px;">36</div>
        </div>
        <div class="damisam">
        </div>
    </form>
</body>
</html>
