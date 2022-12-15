import "./App.css";
// components
import Header from "./components/Header";
import Cards from "./components/Cards";
import { FilterProvider } from "./components/FilterContext";
import { BrowserRouter } from "react-router-dom";
import { RouterConfig } from "./routes/RouterConfig";

function App() {
  return (
    <div className="App">
      {/* <CheckOut /> */}
      <BrowserRouter>
        <RouterConfig></RouterConfig>
      </BrowserRouter>
    </div>
  );
}

export default App;
