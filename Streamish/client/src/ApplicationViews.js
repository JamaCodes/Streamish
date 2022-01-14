import React from "react";
import { BrowserRouter as Router } from "react-router-dom";

import { Switch, Route, Redirect } from "react-router-dom";
import Login from "./components/Login";
import Register from "./components/Register";
import VideoList from "./components/VideoList";

export default function ApplicationViews({ isLoggedIn }) {
  return (
    <main>
      <Router>
              <Switch>
        <Route path="/" exact>
          {isLoggedIn ? <VideoList /> : <Redirect to="/login" />}
        </Route>

        <Route path="/login">
          <Login />
        </Route>

        <Route path="/register">
          <Register />
        </Route>
      </Switch>
      </Router>

    </main>
  );
};
