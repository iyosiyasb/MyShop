var WholesaleService = React.createClass({
    render: function () {
        return (
            <div> 


                <div className="home-box home-box-service">
                    <div className="inside">
                        <div className="subtitle">Our Lady's bakery</div>
                        <div className="title">Wholesale service</div>
                       
                        <div className="desc">
                            <p>Our Lady’s wholesale business strives to exceed expectations by delivering FRESH products 365 days a year.   </p>
                            <p>Please call us today <strong>972-602-0601</strong>  We'd be delighted to give you a personal tour of our facility, and for wholesale buyers, access to the our user-friendly Web Ordering System.</p>
                        </div>
                    </div>
                    </div>




            </div>
        );
    }

});

React.render(
    <WholesaleService/>,
    document.getElementById('container')
); 
