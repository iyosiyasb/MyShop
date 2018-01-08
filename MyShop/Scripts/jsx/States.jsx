var States = React.createClass({
    render: function () {
        return (
            <div>

                <div className="home-states">
                    <div className="inside">
                        <div className="excerpt">From the Heart of Grand prairie to the Heart of Dallas and Beyond</div>
                        <ul>
                            <li> Arlington, TX</li>
                            <li> Grand prairie, TX</li>
                            <li> Richardson, TX</li>
                        </ul>

                        <a href="~/Views/Home/About.cshtml" className="button button-gray">More info</a>
                    </div>
                </div>



            </div>
        );
    }

});

React.render(
    <States/>,
    document.getElementById('component')
); 
