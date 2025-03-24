import React, { useEffect, useState } from "react";
import api from "../services/api";

const ApiTeste: React.FC = () => {
  const [message, setMessage] = useState<string>("");

  useEffect(() => {
    api
      .get("/hello")
      .then((response) => setMessage(response.data))
      .catch((error) => console.error("Erro ao buscar dados:", error));
  }, []);

  console.log(message);

  return (
    <>
      <h1>Rota Teste</h1>
      <h2>{message}</h2>
    </>
  );
};

export default ApiTeste;
