var Homeinfo = React.createClass({
	render: function () {
		return (
				<div>
				<div className="page-content">
						<div className="home-content">
							<div className="home-main-content">
								<div className="home-info">
									<div className="title">Welcome to Our Lady's bakery</div>
								<p>Our Lady’s Bakery  We are located in Grand prairie, Texas just outside of Dallas City. Our Lady’s Bakery is known for providing the highest quality freshly baked products at affordable prices with always exceptional service.</p>
								<p>Since opening our doors for business,we have stayed true to our mantra of "Always Fresh".</p>
							</div>
						</div>
					</div>
				</div>
			</div>
		);
	}
});
React.render(
	<Homeinfo/>,
	document.getElementById("rot")
);